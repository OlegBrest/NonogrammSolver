using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogrammSolver
{
    public partial class MainForm : Form
    {
        static int column_index = -1;
        static int row_index = -1;
        public MainForm()
        {
            InitializeComponent();
            LoadProperties();
        }

        /// <summary>
        /// Создание новой сетки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTabBttn_Click(object sender, EventArgs e)
        {
            CreateDGV(sender, e);
        }

        private void CreateDGV(object sender, EventArgs e)
        {
            this.gridView.Rows.Clear();
            this.gridView.Columns.Clear();

            for (int column = 0; column < this.VerticalSize.Value; column++)
            {
                int ColNum = this.gridView.Columns.Add(new DataGridViewTextBoxColumn());
                this.gridView.Columns[ColNum].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int row = 0; row < this.HorizontSize.Value; row++)
            {
                this.gridView.Rows.Add();

            }
            this.gridView.CurrentCell = null;
            column_index = -1;
            row_index = -1;
        }

        private void CreateDGV(string[] Rows, string[] Columns)
        {
            DataGridView dgv = this.gridView;
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int column = 0; column < Columns.Length; column++)
            {
                int ColNum = dgv.Columns.Add(new DataGridViewTextBoxColumn());
                dgv.Columns[ColNum].HeaderText = Columns[column];
                dgv.Columns[ColNum].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int row = 0; row < Rows.Length; row++)
            {
                int RowNum = dgv.Rows.Add();
                dgv.Rows[RowNum].HeaderCell.Value = Rows[row];
            }
            dgv.CurrentCell = null;
            column_index = -1;
            row_index = -1;
        }

        private void gridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.CurrentCell = null;
            this.DataTextBox.Text = dgv.Columns[e.ColumnIndex].HeaderText.Replace("\n", ";");
            this.DataTextBox.Visible = true;
            this.SendValuesBttn.Visible = true;
            row_index = -1;
            column_index = e.ColumnIndex;
        }

        private void gridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            this.DataTextBox.Text = dgv.Rows[e.RowIndex].HeaderCell.Value == null ? "" : dgv.Rows[e.RowIndex].HeaderCell.Value.ToString();
            this.DataTextBox.Visible = true;
            this.SendValuesBttn.Visible = true;
            column_index = -1;
            row_index = e.RowIndex;
        }

        private void SendValuesBttn_Click(object sender, EventArgs e)
        {

            DataGridView dgv = this.gridView;
            if (column_index >= 0) dgv.Columns[column_index].HeaderText = this.DataTextBox.Text.Replace(";", "\n");
            if (row_index >= 0) dgv.Rows[row_index].HeaderCell.Value = this.DataTextBox.Text;
            this.DataTextBox.Visible = false;
            this.SendValuesBttn.Visible = false;
        }

        private void StartBttn_Click(object sender, EventArgs e)
        {
            TrivialFinder();
            FirstChanceFinder();
        }

        private void DataTextBox_VisibleChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Visible)
            {
                tb.Focus();
                tb.SelectAll();
            }
            else
            {
                column_index = -1;
                row_index = -1;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProperties();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoadProperties();
            if (this.gridView != null)
            {
                this.HorizontSize.Value = this.gridView.ColumnCount;
                this.VerticalSize.Value = this.gridView.RowCount;
            }
        }

        #region Solvemethods
        /// <summary>
        /// Поиск тривиальных линий по вертикали и горизонтали
        /// </summary>
        private void TrivialFinder()
        {
            DataGridView dgv = this.gridView;
            int dgv_rows = dgv.Rows.Count;
            int dgv_columns = dgv.Columns.Count;
            for (int i = 0; i < dgv_columns; i++)
            {
                DataGridViewColumn dgvc = dgv.Columns[i];
                int[] values = Array.ConvertAll(dgvc.HeaderCell.FormattedValue.ToString().Split('\n'), int.Parse);
                if ((values.Sum() == dgv_rows) || ((values.Sum() + (values.Count() - 1)) == dgv_rows))
                {
                    int cur_row = 0;
                    for (int a = 0; a < values.Count(); a++)
                    {
                        for (int aa = 0; aa < values[a]; aa++)
                        {
                            //dgv.Rows[cur_row].Cells[i].Style.BackColor = Color.Black;
                            if ((dgv.Rows[cur_row].Cells[i].Value == null) || (!dgv.Rows[cur_row].Cells[i].Value.ToString().Contains(a + "C")))
                            {
                                dgv.Rows[cur_row].Cells[i].Value += (a + "C");
                            }
                            cur_row++;
                        }
                        cur_row++;
                        if (cur_row < dgv_rows) dgv.Rows[cur_row].Cells[i].Value = "X";
                        dgv.Update();
                    }
                }
            }

            for (int i = 0; i < dgv_rows; i++)
            {
                DataGridViewRow dgvr = dgv.Rows[i];
                int[] values = Array.ConvertAll(dgvr.HeaderCell.FormattedValue.ToString().Split(';'), int.Parse);
                if ((values.Sum() == dgv_columns) || ((values.Sum() + (values.Count() - 1)) == dgv_columns))
                {
                    int cur_column = 0;
                    for (int a = 0; a < values.Count(); a++)
                    {
                        for (int aa = 0; aa < values[a]; aa++)
                        {
                            //dgv.Rows[i].Cells[cur_column].Style.BackColor = Color.Black;
                            if ((dgv.Rows[i].Cells[cur_column].Value == null) || (!dgv.Rows[i].Cells[cur_column].Value.ToString().Contains(a + "R")))
                            {
                                dgv.Rows[i].Cells[cur_column].Value += (a + "R");
                            }
                            cur_column++;
                        }
                        cur_column++;
                        if (cur_column < dgv_columns) dgv.Rows[i].Cells[cur_column].Value = "X"
                                ;
                        dgv.Update();
                    }
                }
            }

            dgv.CurrentCell = null;
        }

        private void FirstChanceFinder()
        {
            DataGridView dgv = this.gridView;
            int dgv_rows = dgv.Rows.Count;
            int dgv_columns = dgv.Columns.Count;

            for (int i = 0; i < dgv_columns; i++)
            {
                DataGridViewColumn dgvc = dgv.Columns[i];
                int[] values = Array.ConvertAll(dgvc.HeaderCell.FormattedValue.ToString().Split('\n'), int.Parse);
                if ((values.Sum() > dgv_rows / 2) || ((values.Sum() + (values.Count() - 1)) > dgv_rows / 2))
                {
                    int cur_row = 0;
                    for (int a = 0; a < values.Count(); a++)
                    {
                        for (int aa = 0; aa < values[a]; aa++)
                        {
                            //dgv.Rows[cur_row].Cells[i].Style.BackColor = Color.Black;
                            if (dgv.Rows[cur_row].Cells[i].Value == null)
                            {
                                dgv.Rows[cur_row].Cells[i].Value += (a + "C");
                            }
                            cur_row++;
                        }
                        cur_row++;
                        dgv.Update();
                    }
                    for (int a = values.Count() - 1; a >= 0; a--)
                    {
                        for (int aa = 0; aa < values[a]; aa++)
                        {
                            //dgv.Rows[cur_row].Cells[i].Style.BackColor = Color.Black;

                            if ((dgv.Rows[cur_row].Cells[i].Value != null) && (dgv.Rows[cur_row].Cells[i].Value.ToString().Contains(a + "C")))
                            {
                                dgv.Rows[cur_row].Cells[i].Style.BackColor = Color.Black;
                            }
                            if ((dgv.Rows[cur_row].Cells[i].Value == null) || ((!dgv.Rows[cur_row].Cells[i].Value.ToString().Equals("X")) && (!dgv.Rows[cur_row].Cells[i].Value.ToString().Contains(a + "C"))))
                            {
                                dgv.Rows[cur_row].Cells[i].Value += (a + "C");
                            }
                            cur_row--;
                        }
                        cur_row--;
                        dgv.Update();
                    }
                }
            }

            for (int i = 0; i < dgv_rows; i++)
            {
                DataGridViewRow dgvr = dgv.Rows[i];
                int[] values = Array.ConvertAll(dgvr.HeaderCell.Value.ToString().Split(';'), int.Parse);
                if ((values.Sum() > dgv_columns / 2) || ((values.Sum() + (values.Count() - 1)) > dgv_columns / 2))
                {
                    int cur_column = 0;
                    for (int a = 0; a < values.Count(); a++)
                    {
                        for (int aa = 0; aa < values[a]; aa++)
                        {
                            //dgv.Rows[cur_row].Cells[i].Style.BackColor = Color.Black;
                            if (dgv.Rows[i].Cells[cur_column].Value == null)
                            {
                                dgv.Rows[i].Cells[cur_column].Value = (a + "R");
                            }
                            else if (!dgv.Rows[i].Cells[cur_column].Value.ToString().Equals("X"))
                            {
                                dgv.Rows[i].Cells[cur_column].Value += (a + "R");
                            }
                            cur_column++;
                        }
                        cur_column++;
                        dgv.Update();
                    }
                    for (int a = values.Count() - 1; a >= 0; a--)
                    {
                        for (int aa = 0; aa < values[a]; aa++)
                        {
                            if ((dgv.Rows[i].Cells[cur_column].Value != null) && (dgv.Rows[i].Cells[cur_column].Value.ToString().Contains(a + "R")))
                            {
                                dgv.Rows[i].Cells[cur_column].Style.BackColor = Color.Black;
                            }
                            if ((dgv.Rows[i].Cells[cur_column].Value == null) || ((!dgv.Rows[i].Cells[cur_column].Value.ToString().Equals("X")) && (!dgv.Rows[i].Cells[cur_column].Value.ToString().Contains(a + "R"))))
                            {
                                dgv.Rows[i].Cells[cur_column].Value += (a + "R");
                            }
                            cur_column--;
                        }
                        cur_column--;
                        dgv.Update();
                    }
                }
            }
        }


        #endregion



        #region  methods for properties
        private string GetRows()
        {
            string retval = "";

            foreach (DataGridViewRow dgvr in this.gridView.Rows)
            {
                if (retval != "") retval += "|";
                retval += dgvr.HeaderCell.Value == null ? " " : dgvr.HeaderCell.Value;
            }
            return retval;
        }

        private string GetColumns()
        {
            string retval = "";

            foreach (DataGridViewColumn dgvc in this.gridView.Columns)
            {
                if (retval != "") retval += "|";
                retval += dgvc.HeaderText == "" ? " " : dgvc.HeaderText;
            }
            return retval;
        }

        private void SaveProperties()
        {
            string Rows = GetRows();
            string Columns = GetColumns();
            Properties.Settings.Default.rows_values = Rows;
            Properties.Settings.Default.columns_values = Columns;
            Properties.Settings.Default.Save();
        }

        private void LoadProperties()
        {
            string[] Rows = Properties.Settings.Default.rows_values.Split('|');
            string[] Columns = Properties.Settings.Default.columns_values.Split('|');

            if ((Rows.Length > 0) && (Columns.Length > 0))
            {
                CreateDGV(Rows, Columns);
            }
        }

        #endregion
    }
}
