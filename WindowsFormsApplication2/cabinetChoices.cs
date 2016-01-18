using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Configuration;

namespace WindowsFormsApplication2
{
    public partial class SkapDetaljer : Form
    {
        DataAccess da = new DataAccess();
        private DataTable dt = new DataTable();
        private DataTable dtAll = new DataTable();
        int rowIndex = 0;
        
        public SkapDetaljer()
        {
            InitializeComponent();            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Boolean Check()
        {
            try
            {
                if (textBoxProjectNo.Text == "")
                {
                    label6.Visible = true;
                    textBoxProjectNo.Focus();
                    return false;
                }
                else if (textBoxQuoteNo.Text == "")
                {
                    label6.Visible = true;
                    textBoxQuoteNo.Focus();
                    return false;
                }
                else if (textBoxProjectName.Text == "")
                {
                    label6.Visible = true;
                    textBoxProjectName.Focus();
                    return false;
                }
                else
                {
                    label6.Visible = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                InsertOrder();
            }
            else
            {
                label6.Visible = true;
            }
        }
        private void InsertOrder()
        {
            try
            {
                da.ProcName = "InsertOrder";
                da.OpenDBConnection();
                da.CreateCommandObject();
                da.Parameters("@CustID", int.Parse(comboBoxSelectCustomer.SelectedValue.ToString()));
                da.Parameters("@Project_No", textBoxProjectNo.Text);
                da.Parameters("@Quote_No", textBoxQuoteNo.Text);
                da.Parameters("@Project_Name", textBoxProjectName.Text);
                //da.Parameters("@Status", );                
                da.ExecuteNonQuery();
                //empty();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                da.CloseConnection();
            }
        }

        private void SkapDetaljer_Load(object sender, EventArgs e)
        {
            ProjectNo();
            FillDropDown();
        }
        private void FillDropDown()
        {
            try
            {
                da.ProcName = "GetCustomers";
                da.OpenDBConnection();
                da.CreateCommandObject();
                dt = da.FillDataTable();
                comboBoxSelectCustomer.DisplayMember = "Customer_Name";
                comboBoxSelectCustomer.ValueMember = "Customer_ID";
                comboBoxSelectCustomer.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                da.CloseConnection();
            }
        }

        private void ProjectNo()
        {
            try
            {
                da.ProcName = "GetMaxValue";
                da.OpenDBConnection();
                da.CreateCommandObject();
                da.Parameters("@TableName", "[Order]"); 
                da.Parameters("@Key", "[Project_No]");
                textBoxProjectNo.Text = da.FillDataTable().Rows[0][0].ToString();
                if (textBoxProjectNo.Text == "")
                {
                    textBoxProjectNo.Text = "1";
                }
            }
            catch (Exception ex)
            { }
            finally
            {
                da.CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                FillGrid();
                Empty();
                int z = 0;
                //z = Convert.ToInt32(textBox4.ToString());
            }
        }
        private void FillGrid()
        {
            try
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();
                DataTable dt6 = new DataTable();
                DataTable dt7 = new DataTable();
                DataTable dt8 = new DataTable();
                DataTable dt9 = new DataTable();



                if (tapL.Checked == true && tapM.Checked == false && tapX.Checked == false && tapK.Text == "" && tapV.Text == "")
                {

                    da.ProcName = "GetLCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt1 = da.FillDataTable();
                    if (dataGridView1.DataSource == null)
                    {
                        dataGridView1.DataSource = dt1;
                        dtAll = dt1.Copy();
                    }
                    else
                    {
                        dtAll.Merge(dt1, true);
                        dataGridView1.DataSource = dtAll;
                    }
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                else if (tapL.Checked == false && tapM.Checked == true && tapX.Checked == false && tapK.Text == "" && tapV.Text == "")
                {
                    da.ProcName = "GetMCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt2 = da.FillDataTable();
                    dataGridView1.DataSource = dt2;

                    dtAll.Merge(dt2, true);
                    dataGridView1.DataSource = dtAll;

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                else if (tapL.Checked == false && tapM.Checked == false && tapX.Checked == true && tapK.Text == "" && tapV.Text == "")
                {
                    da.ProcName = "GetXCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt3 = da.FillDataTable();
                    dataGridView1.DataSource = dt3;

                    dtAll.Merge(dt3, true);
                    dataGridView1.DataSource = dtAll;

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                ///////////////
                else if (tapL.Checked == true && tapM.Checked == true && tapX.Checked == false && tapK.Text == "" && tapV.Text == "")
                {
                    da.ProcName = "GetLorMCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt4 = da.FillDataTable();
                    dataGridView1.DataSource = dt4;

                    dtAll.Merge(dt4, true);
                    dataGridView1.DataSource = dtAll;

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                else if (tapL.Checked == true && tapM.Checked == false && tapX.Checked == true && tapK.Text == "" && tapV.Text == "")
                {
                    da.ProcName = "GetLorXCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt5 = da.FillDataTable();
                    dataGridView1.DataSource = dt5;

                    dtAll.Merge(dt5, true);
                    dataGridView1.DataSource = dtAll;

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                else if (tapL.Checked == false && tapM.Checked == true && tapX.Checked == true && tapK.Text == "" && tapV.Text == "")
                {
                    da.ProcName = "GetMorXCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt6 = da.FillDataTable();
                    dataGridView1.DataSource = dt6;

                    dtAll.Merge(dt6, true);
                    dataGridView1.DataSource = dtAll;

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                else if (tapL.Checked == true && tapM.Checked == true && tapX.Checked == true && tapK.Text == "" && tapV.Text == "")
                {
                    da.ProcName = "GetLorMorXCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt7 = da.FillDataTable();
                    dataGridView1.DataSource = dt7;

                    dtAll.Merge(dt7, true);
                    dataGridView1.DataSource = dtAll;

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                ////////////////
                else if (tapL.Checked == false && tapM.Checked == false && tapX.Checked == false && tapK.Text != "" && tapV.Text == "")
                {
                    da.ProcName = "GetKCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt8 = da.FillDataTable();
                    if (dataGridView1.DataSource == null)
                    {
                        dataGridView1.DataSource = dt8;
                        dtAll = dt8.Copy();
                    }
                    else
                    {
                        dtAll.Merge(dt1, true);
                        dataGridView1.DataSource = dtAll;
                    }
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                else if (tapL.Checked && tapM.Checked == false && tapX.Checked == false && tapK.Text == "" && tapV.Text != "")
                {
                    da.ProcName = "GetVCat";
                    da.OpenDBConnection();
                    da.CreateCommandObject();
                    dt9 = da.FillDataTable();
                    if (dataGridView1.DataSource == null)
                    {
                        dataGridView1.DataSource = dt9;
                        dtAll = dt9.Copy();
                    }
                    else
                    {
                        dtAll.Merge(dt1, true);
                        dataGridView1.DataSource = dtAll;
                    }
                    dataGridView1.Rows[rowIndex].Cells[0].Value = cabNo.Text.ToString();
                    rowIndex = rowIndex + 1;
                }
                //dtAll = dt1.Copy();
                //dtAll.Merge(dt2, true);
                //dataGridView1.DataSource = dtAll;
                //dataGridView1.DataBind();
                //string firstColum = txtUomtyp.Text;
                //string secondColum = txtUomDesc.Text;
                //string[] row = { firstColum, secondColum };
                //dataGridView1.Rows.Add(row);

                //dataGridView1.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
       private void Empty()
        {
            cabNo.Text = "";
            cabQuantity.Text = "";
            tapK.Text = "";
            tapV.Text = "";
            heatR.Text = "";
            heatG.Text = "";
            cabSizeW.Text = "";
            cabSizeH.Text = "";
            cabSizeD.Text = "";
            roomType.Text = "";
            roomId.Text = "";
            adminHours.Text = "";
            tapL.Checked = false;
            tapM.Checked = false;
            tapX.Checked = false;
            heatM.Checked = false;
            heatShare.Checked = false;
            heatT.Checked = false;
            heatTm.Checked = false;
            heatS.Checked = false;
            heatX.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tapL_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
