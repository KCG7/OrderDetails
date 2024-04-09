using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using OrderDetails.VesigoOrdersService;

namespace OrderDetails
{
    public partial class Form1 : Form
    {
        // Initialize Connection String

        SqlConnection objConnection = new SqlConnection("Server=Krishna-PC\\SQLEXPRESS;database=TEST;Trusted_Connection=yes;connection timeout=600");

        // In case of SQL Authentication

        //SqlConnection objConnection = new SqlConnection("server=<Server_Name>'; user id='<User_id>'; password='<Password>'; database='<database_name>';Connect Timeout=600");
        public Form1()
        {
            try
            {
                InitializeComponent();
                // Estimate Start & End Dates
                DateTime sDate = DateTime.Now.AddDays(-500);
                DateTime eDate = DateTime.Now;

                // Get the Order Details from VesigoOrderService
                VesigoOrdersService.orders_internal service = new VesigoOrdersService.orders_internal();
                // Call GetOrdersByStatus function from the Web service
                var output = service.GetOrdersByStatus("29475d4e-34d8-4883-b6f0-f6836ddd60b4", 2, sDate, eDate);

                // Insert the fetched Order Details from Web service into Database
                InsertOrderDetails(output);
                // Get the Order Details from Database and display on DataGridView
                GetOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an issue connecting to Webservice.." + " " + Convert.ToString(ex));
            }


        }

        public void InsertOrderDetails(string[] OrderNumber)
        {
            try
            {
                objConnection.Open();
                for (int i = 0; i < OrderNumber.Length; i++)
                {
                    SqlCommand objSQLCmd = new SqlCommand("INSERTORDERDETAILS", objConnection);
                    objSQLCmd.CommandType = CommandType.StoredProcedure;
                    string oNum = OrderNumber[i].ToString();
                    //Input Parameter
                    objSQLCmd.Parameters.Add(new SqlParameter("@oNumber", oNum));

                    //	Output Paramter
                    SqlParameter paramResult = objSQLCmd.Parameters.Add(new SqlParameter("@result", System.Data.SqlDbType.Bit));
                    paramResult.Direction = ParameterDirection.Output;

                    //	Run it
                    objSQLCmd.ExecuteNonQuery();
                }

                objConnection.Close();

                MessageBox.Show("Order Details have been inserted into database. Click 'Ok' to view the list of orders.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }

        }

        private void BindToGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select ORDER_NUMBER from dbo.ORDERDETAILS", objConnection);
                //Instantiate DataAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                //Instantiate DataTable
                DataTable dt = new DataTable();
                //Fill DataAdapter with DataTable details
                dataAdapter.Fill(dt);
                // Bind data to Grid
                gvOrderDetails.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }

        }

        private void GetOrderDetails()
        {

            BindToGrid();

        }
    }
}
