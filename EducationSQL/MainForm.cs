using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using Point = System.Drawing.Point;

namespace EducationSQL
{
    public partial class MainForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Password=1234;Username=postgres;Database=educationBD";
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectButton_MouseEnter(object sender, EventArgs e)
        {
            selectButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "selectLight.png"));
        }

        private void selectButton_MouseLeave(object sender, EventArgs e)
        {
            selectButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "select.png"));
        }

        private void whereButton_MouseEnter(object sender, EventArgs e)
        {
            whereButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "whereLight.png"));
        }

        private void whereButton_MouseLeave(object sender, EventArgs e)
        {
            whereButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "where.png"));
        }

        private void havingButton_MouseEnter(object sender, EventArgs e)
        {
            havingButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "havingLight.png"));
        }

        private void havingButton_MouseLeave(object sender, EventArgs e)
        {
            havingButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "having.png"));
        }

        private void betweenButton_MouseEnter(object sender, EventArgs e)
        {
            betweenButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images",
                "between-in-not_inLight.png"));
        }

        private void betweenButton_MouseLeave(object sender, EventArgs e)
        {
            betweenButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images",
                "between-in-not_in.png"));
        }

        private void group_byButton_MouseEnter(object sender, EventArgs e)
        {
            group_byButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "group_byLight.png"));
        }

        private void group_byButton_MouseLeave(object sender, EventArgs e)
        {
            group_byButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "group_by.png"));
        }

        private void order_byButton_MouseEnter(object sender, EventArgs e)
        {
            order_byButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "order_byLight.png"));
        }

        private void order_byButton_MouseLeave(object sender, EventArgs e)
        {
            order_byButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "order_by.png"));
        }

        private void limitButton_MouseEnter(object sender, EventArgs e)
        {
            limitButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images",
                "limit-offsetLight.png"));
        }

        private void limitButton_MouseLeave(object sender, EventArgs e)
        {
            limitButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "limit-offset.png"));
        }

        private void unionButton_MouseEnter(object sender, EventArgs e)
        {
            unionButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "unionLight.png"));
        }

        private void unionButton_MouseLeave(object sender, EventArgs e)
        {
            unionButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "union.png"));
        }

        private void intersectButton_MouseEnter(object sender, EventArgs e)
        {
            intersectButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "intersectLight.png"));
        }

        private void intersectButton_MouseLeave(object sender, EventArgs e)
        {
            intersectButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "intersect.png"));
        }

        private void exceptButton_MouseEnter(object sender, EventArgs e)
        {
            exceptButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "exceptLight.png"));
        }

        private void exceptButton_MouseLeave(object sender, EventArgs e)
        {
            exceptButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "except.png"));
        }

        private void distinctButton_MouseEnter(object sender, EventArgs e)
        {
            distinctButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "distinctLight.png"));
        }

        private void distinctButton_MouseLeave(object sender, EventArgs e)
        {
            distinctButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "distinct.png"));
        }

        private void inner_joinButton_MouseEnter(object sender, EventArgs e)
        {
            inner_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "inner_joinLight.png"));
        }

        private void inner_joinButton_MouseLeave(object sender, EventArgs e)
        {
            inner_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "inner_join.png"));
        }

        private void left_joinButton_MouseEnter(object sender, EventArgs e)
        {
            left_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "left_joinLight.png"));
        }

        private void left_joinButton_MouseLeave(object sender, EventArgs e)
        {
            left_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "left_join.png"));
        }

        private void right_joinButton_MouseEnter(object sender, EventArgs e)
        {
            right_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "right_joinLight.png"));
        }

        private void right_joinButton_MouseLeave(object sender, EventArgs e)
        {
            right_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "right_join.png"));
        }

        private void cross_joinButton_MouseEnter(object sender, EventArgs e)
        {
            cross_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "cross_joinLight.png"));
        }

        private void cross_joinButton_MouseLeave(object sender, EventArgs e)
        {
            cross_joinButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "cross_join.png"));
        }

        private void avgButton_MouseEnter(object sender, EventArgs e)
        {
            avgButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "avgLight.png"));
        }

        private void avgButton_MouseLeave(object sender, EventArgs e)
        {
            avgButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "avg.png"));
        }

        private void sumButton_MouseEnter(object sender, EventArgs e)
        {
            sumButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "sumLight.png"));
        }

        private void sumButton_MouseLeave(object sender, EventArgs e)
        {
            sumButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "sum.png"));
        }

        private void countButton_MouseEnter(object sender, EventArgs e)
        {
            countButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "countLight.png"));
        }

        private void countButton_MouseLeave(object sender, EventArgs e)
        {
            countButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "count.png"));
        }

        private void subqueriesButton_MouseEnter(object sender, EventArgs e)
        {
            subqueriesButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "subqueriesLight.png"));
        }

        private void subqueriesButton_MouseLeave(object sender, EventArgs e)
        {
            subqueriesButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "subqueries.png"));
        }

        private void concatenationButton_MouseEnter(object sender, EventArgs e)
        {
            concatenationButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images",
                "concatenationLight.png"));
        }

        private void concatenationButton_MouseLeave(object sender, EventArgs e)
        {
            concatenationButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "concatenation.png"));
        }

        private void diagramButton_MouseEnter(object sender, EventArgs e)
        {
            diagramButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "diagramLight.png"));
        }

        private void diagramButton_MouseLeave(object sender, EventArgs e)
        {
            diagramButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "diagram.png"));
        }

        private void contentButton_MouseEnter(object sender, EventArgs e)
        {
            contentButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "contentLight.png"));
        }

        private void contentButton_MouseLeave(object sender, EventArgs e)
        {
            contentButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "content.png"));
        }

        private void runButton_MouseEnter(object sender, EventArgs e)
        {
            runButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "runLight.png"));
        }

        private void runButton_MouseLeave(object sender, EventArgs e)
        {
            runButton.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "run.png"));
        }

        private void clearButton_MouseEnter(object sender, EventArgs e)
        {
            clearButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "clearLight.png"));
        }

        private void clearButton_MouseLeave(object sender, EventArgs e)
        {
            clearButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "clear.png"));
        }

        private void exportButton_MouseEnter(object sender, EventArgs e)
        {
            exportButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "exportLight.png"));
        }

        private void exportButton_MouseLeave(object sender, EventArgs e)
        {
            exportButton.Image =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "export.png"));
        }

        private void selectButton_MouseDown(object sender, MouseEventArgs e)
        {
            selectButton.Location = new Point(selectButton.Location.X + 2, selectButton.Location.Y + 2);
        }

        private void selectButton_MouseUp(object sender, MouseEventArgs e)
        {
            selectButton.Location = new Point(selectButton.Location.X - 2, selectButton.Location.Y - 2);
        }

        private void whereButton_MouseDown(object sender, MouseEventArgs e)
        {
            whereButton.Location = new Point(whereButton.Location.X + 2, whereButton.Location.Y + 2);
        }

        private void whereButton_MouseUp(object sender, MouseEventArgs e)
        {
            whereButton.Location = new Point(whereButton.Location.X - 2, whereButton.Location.Y - 2);
        }

        private void havingButton_MouseDown(object sender, MouseEventArgs e)
        {
            havingButton.Location = new Point(havingButton.Location.X + 2, havingButton.Location.Y + 2);
        }

        private void havingButton_MouseUp(object sender, MouseEventArgs e)
        {
            havingButton.Location = new Point(havingButton.Location.X - 2, havingButton.Location.Y - 2);
        }

        private void betweenButton_MouseDown(object sender, MouseEventArgs e)
        {
            betweenButton.Location = new Point(betweenButton.Location.X + 2, betweenButton.Location.Y + 2);
        }

        private void betweenButton_MouseUp(object sender, MouseEventArgs e)
        {
            betweenButton.Location = new Point(betweenButton.Location.X - 2, betweenButton.Location.Y - 2);
        }

        private void group_byButton_MouseDown(object sender, MouseEventArgs e)
        {
            group_byButton.Location = new Point(group_byButton.Location.X + 2, group_byButton.Location.Y + 2);
        }

        private void group_byButton_MouseUp(object sender, MouseEventArgs e)
        {
            group_byButton.Location = new Point(group_byButton.Location.X - 2, group_byButton.Location.Y - 2);
        }

        private void order_byButton_MouseDown(object sender, MouseEventArgs e)
        {
            order_byButton.Location = new Point(order_byButton.Location.X + 2, order_byButton.Location.Y + 2);
        }

        private void order_byButton_MouseUp(object sender, MouseEventArgs e)
        {
            order_byButton.Location = new Point(order_byButton.Location.X - 2, order_byButton.Location.Y - 2);
        }

        private void limitButton_MouseDown(object sender, MouseEventArgs e)
        {
            limitButton.Location = new Point(limitButton.Location.X + 2, limitButton.Location.Y + 2);
        }

        private void limitButton_MouseUp(object sender, MouseEventArgs e)
        {
            limitButton.Location = new Point(limitButton.Location.X - 2, limitButton.Location.Y - 2);
        }

        private void unionButton_MouseDown(object sender, MouseEventArgs e)
        {
            unionButton.Location = new Point(unionButton.Location.X + 2, unionButton.Location.Y + 2);
        }

        private void unionButton_MouseUp(object sender, MouseEventArgs e)
        {
            unionButton.Location = new Point(unionButton.Location.X - 2, unionButton.Location.Y - 2);
        }

        private void intersectButton_MouseDown(object sender, MouseEventArgs e)
        {
            intersectButton.Location = new Point(intersectButton.Location.X + 2, intersectButton.Location.Y + 2);
        }

        private void intersectButton_MouseUp(object sender, MouseEventArgs e)
        {
            intersectButton.Location = new Point(intersectButton.Location.X - 2, intersectButton.Location.Y - 2);
        }

        private void exceptButton_MouseDown(object sender, MouseEventArgs e)
        {
            exceptButton.Location = new Point(exceptButton.Location.X + 2, exceptButton.Location.Y + 2);
        }

        private void exceptButton_MouseUp(object sender, MouseEventArgs e)
        {
            exceptButton.Location = new Point(exceptButton.Location.X - 2, exceptButton.Location.Y - 2);
        }

        private void distinctButton_MouseDown(object sender, MouseEventArgs e)
        {
            distinctButton.Location = new Point(distinctButton.Location.X + 2, distinctButton.Location.Y + 2);
        }

        private void distinctButton_MouseUp(object sender, MouseEventArgs e)
        {
            distinctButton.Location = new Point(distinctButton.Location.X - 2, distinctButton.Location.Y - 2);
        }

        private void inner_joinButton_MouseDown(object sender, MouseEventArgs e)
        {
            inner_joinButton.Location = new Point(inner_joinButton.Location.X + 2, inner_joinButton.Location.Y + 2);
        }

        private void inner_joinButton_MouseUp(object sender, MouseEventArgs e)
        {
            inner_joinButton.Location = new Point(inner_joinButton.Location.X - 2, inner_joinButton.Location.Y - 2);
        }

        private void left_joinButton_MouseDown(object sender, MouseEventArgs e)
        {
            left_joinButton.Location = new Point(left_joinButton.Location.X + 2, left_joinButton.Location.Y + 2);
        }

        private void left_joinButton_MouseUp(object sender, MouseEventArgs e)
        {
            left_joinButton.Location = new Point(left_joinButton.Location.X - 2, left_joinButton.Location.Y - 2);
        }

        private void right_joinButton_MouseDown(object sender, MouseEventArgs e)
        {
            right_joinButton.Location = new Point(right_joinButton.Location.X + 2, right_joinButton.Location.Y + 2);
        }

        private void right_joinButton_MouseUp(object sender, MouseEventArgs e)
        {
            right_joinButton.Location = new Point(right_joinButton.Location.X - 2, right_joinButton.Location.Y - 2);
        }

        private void cross_joinButton_MouseDown(object sender, MouseEventArgs e)
        {
            cross_joinButton.Location = new Point(cross_joinButton.Location.X + 2, cross_joinButton.Location.Y + 2);
        }

        private void cross_joinButton_MouseUp(object sender, MouseEventArgs e)
        {
            cross_joinButton.Location = new Point(cross_joinButton.Location.X - 2, cross_joinButton.Location.Y - 2);
        }

        private void avgButton_MouseDown(object sender, MouseEventArgs e)
        {
            avgButton.Location = new Point(avgButton.Location.X + 2, avgButton.Location.Y + 2);
        }

        private void avgButton_MouseUp(object sender, MouseEventArgs e)
        {
            avgButton.Location = new Point(avgButton.Location.X - 2, avgButton.Location.Y - 2);
        }

        private void sumButton_MouseDown(object sender, MouseEventArgs e)
        {
            sumButton.Location = new Point(sumButton.Location.X + 2, sumButton.Location.Y + 2);
        }

        private void sumButton_MouseUp(object sender, MouseEventArgs e)
        {
            sumButton.Location = new Point(sumButton.Location.X - 2, sumButton.Location.Y - 2);
        }

        private void countButton_MouseDown(object sender, MouseEventArgs e)
        {
            countButton.Location = new Point(countButton.Location.X + 2, countButton.Location.Y + 2);
        }

        private void countButton_MouseUp(object sender, MouseEventArgs e)
        {
            countButton.Location = new Point(countButton.Location.X - 2, countButton.Location.Y - 2);
        }

        private void subqueriesButton_MouseDown(object sender, MouseEventArgs e)
        {
            subqueriesButton.Location = new Point(subqueriesButton.Location.X + 2, subqueriesButton.Location.Y + 2);
        }

        private void subqueriesButton_MouseUp(object sender, MouseEventArgs e)
        {
            subqueriesButton.Location = new Point(subqueriesButton.Location.X - 2, subqueriesButton.Location.Y - 2);
        }

        private void concatenationButton_MouseDown(object sender, MouseEventArgs e)
        {
            concatenationButton.Location = new Point(concatenationButton.Location.X + 2, concatenationButton.Location.Y + 2);
        }

        private void concatenationButton_MouseUp(object sender, MouseEventArgs e)
        {
            concatenationButton.Location = new Point(concatenationButton.Location.X - 2, concatenationButton.Location.Y - 2);
        }

        private void diagramButton_MouseDown(object sender, MouseEventArgs e)
        {
            diagramButton.Location = new Point(diagramButton.Location.X + 2, diagramButton.Location.Y + 2);
        }

        private void diagramButton_MouseUp(object sender, MouseEventArgs e)
        {
            diagramButton.Location = new Point(diagramButton.Location.X - 2, diagramButton.Location.Y - 2);
        }

        private void contentButton_MouseDown(object sender, MouseEventArgs e)
        {
            contentButton.Location = new Point(contentButton.Location.X + 2, contentButton.Location.Y + 2);
        }

        private void contentButton_MouseUp(object sender, MouseEventArgs e)
        {
            contentButton.Location = new Point(contentButton.Location.X - 2, contentButton.Location.Y - 2);
        }

        private void runButton_MouseDown(object sender, MouseEventArgs e)
        {
            runButton.Location = new Point(runButton.Location.X + 2, runButton.Location.Y + 2);
        }

        private void runButton_MouseUp(object sender, MouseEventArgs e)
        {
            runButton.Location = new Point(runButton.Location.X - 2, runButton.Location.Y - 2);
        }

        private void clearButton_MouseDown(object sender, MouseEventArgs e)
        {
            clearButton.Location = new Point(clearButton.Location.X + 2, clearButton.Location.Y + 2);
        }

        private void clearButton_MouseUp(object sender, MouseEventArgs e)
        {
            clearButton.Location = new Point(clearButton.Location.X - 2, clearButton.Location.Y - 2);
        }

        private void exportButton_MouseDown(object sender, MouseEventArgs e)
        {
            exportButton.Location = new Point(exportButton.Location.X + 2, exportButton.Location.Y + 2);
        }

        private void exportButton_MouseUp(object sender, MouseEventArgs e)
        {
            exportButton.Location = new Point(exportButton.Location.X - 2, exportButton.Location.Y - 2);
        }
        
        private void runButton_Click(object sender, EventArgs e)
        {
            string query = txtQueryInput.Text.Trim();
            
            string[] forbiddenCommands = { "INSERT", "DELETE", "UPDATE", "DROP" };
            
            foreach (string command in forbiddenCommands)
            {
                if (query.ToUpper().Contains(command))
                {
                    MessageBox.Show($"Команда \"{command}\" запрещена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtQueryInput.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
        
        private void ExportToCsv(DataGridView grid, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        writer.Write(grid.Columns[i].HeaderText);
                        if (i < grid.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < grid.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < grid.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }
                }
                
                MessageBox.Show("Экспорт выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void exportButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv";
                saveFileDialog.Title = "Сохранить как";
                saveFileDialog.FileName = "export.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsv(dataGridView1, saveFileDialog.FileName);
                }
            }
        }
    }
}