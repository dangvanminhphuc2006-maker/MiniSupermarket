using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.WinForms
{
    internal sealed class FormPOSLookupDialog<T> : Form where T : class
    {
        private readonly Func<string, Task<List<T>>> _search;
        private readonly TextBox _searchBox;
        private readonly Button _searchButton;
        private readonly Button _selectButton;
        private readonly DataGridView _resultsGrid;
        private readonly Label _statusLabel;

        public FormPOSLookupDialog(
            string title,
            string searchPlaceholder,
            Func<string, Task<List<T>>> search,
            params (string PropertyName, string HeaderText)[] columns)
        {
            _search = search;
            Text = title;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(760, 500);
            Font = new Font("Segoe UI", 9.5F);

            var searchPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 58,
                Padding = new Padding(12)
            };
            _searchBox = new TextBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Segoe UI", 10F),
                Location = new Point(12, 14),
                PlaceholderText = searchPlaceholder,
                Size = new Size(590, 30)
            };
            _searchBox.KeyDown += async (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    await SearchAsync();
                }
            };
            _searchButton = new Button
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.FromArgb(41, 100, 180),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Location = new Point(615, 12),
                Size = new Size(130, 34),
                Text = "Tìm kiếm"
            };
            _searchButton.FlatAppearance.BorderSize = 0;
            _searchButton.Click += async (_, _) => await SearchAsync();
            searchPanel.Controls.Add(_searchBox);
            searchPanel.Controls.Add(_searchButton);

            _statusLabel = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 28,
                Padding = new Padding(12, 4, 0, 0),
                Text = "Nhập tên hoặc mã để lọc danh sách."
            };
            _resultsGrid = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            foreach (var column in columns)
            {
                _resultsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = column.PropertyName,
                    HeaderText = column.HeaderText,
                    Name = column.PropertyName
                });
            }
            _resultsGrid.CellDoubleClick += (_, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    SelectCurrentRow();
                }
            };

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.RightToLeft,
                Height = 52,
                Padding = new Padding(8)
            };
            _selectButton = new Button
            {
                BackColor = Color.FromArgb(40, 167, 69),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Size = new Size(125, 34),
                Text = "Chọn"
            };
            _selectButton.FlatAppearance.BorderSize = 0;
            _selectButton.Click += (_, _) => SelectCurrentRow();
            var cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Size = new Size(100, 34),
                Text = "Đóng"
            };
            buttonPanel.Controls.Add(_selectButton);
            buttonPanel.Controls.Add(cancelButton);
            Controls.Add(_resultsGrid);
            Controls.Add(_statusLabel);
            Controls.Add(buttonPanel);
            Controls.Add(searchPanel);
            AcceptButton = _searchButton;
            CancelButton = cancelButton;
            Shown += async (_, _) => await SearchAsync();
        }

        public T? SelectedItem { get; private set; }
        public string InitialKeyword
        {
            get => _searchBox.Text;
            set => _searchBox.Text = value;
        }

        private async Task SearchAsync()
        {
            _searchButton.Enabled = false;
            _statusLabel.Text = "Đang tìm kiếm...";
            try
            {
                List<T> results = await _search(_searchBox.Text.Trim());
                _resultsGrid.DataSource = results;
                _statusLabel.Text = results.Count == 0
                    ? "Không tìm thấy kết quả phù hợp."
                    : $"{results.Count} kết quả. Nhập thêm từ khóa nếu chưa thấy mục cần chọn.";
            }
            catch (HttpRequestException)
            {
                _resultsGrid.DataSource = null;
                _statusLabel.Text = "Không kết nối được máy chủ.";
                MessageBox.Show(this, "Không thể tải danh sách. Vui lòng kiểm tra kết nối máy chủ rồi thử lại.",
                    "Mất kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (JsonException)
            {
                _resultsGrid.DataSource = null;
                _statusLabel.Text = "Dữ liệu máy chủ không hợp lệ.";
                MessageBox.Show(this, "Máy chủ trả về danh sách không đúng định dạng.",
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _resultsGrid.DataSource = null;
                _statusLabel.Text = "Không thể tải danh sách.";
                MessageBox.Show(this, "Không thể tìm kiếm: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _searchButton.Enabled = true;
            }
        }

        private void SelectCurrentRow()
        {
            SelectedItem = _resultsGrid.CurrentRow?.DataBoundItem as T;
            if (SelectedItem == null)
            {
                MessageBox.Show(this, "Vui lòng chọn một dòng trong danh sách.",
                    "Chưa chọn mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
