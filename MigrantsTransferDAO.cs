
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MigrantsTransferTrackerDAL      //DO NOT change the namespace name
{
    public class MigrantsTransferDAO      //DO NOT change the class name
    {
        //Create public fields here
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;

        

        public MigrantsTransferDAO()
        {
            //Instantiate fields here
            public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings['SqlCon'].ConnectionString;

            }
        }
        }     

        public int AddTransferDetails(DateTime transferDate, 
                                      string fromState, 
                                      string toState, 
                                      int noOfMigrantsTransfered, 
                                      string transferMode, 
                                      string vehicleDetails)
        {
            int RowsAdded = 0;
        //Implement code here. 
        //Do not change method signaturetry{
        try
        {
            connection = new SqlConnection(ConnectionString);
            connection.open();
            string query="insert into MigrantsTransfer(TransferDate,FromState,ToState,MigrantsTransfered,TransferMode,VehicleDetailes) values ("+transferdate+",'"+fromState+"','"+toState+"',"+ noOfMigrantsTransfered+",'"+ transferMode+"','"+ vehicleDetails"');";
            command = new SqlCommand(query, connection);
           RowsAdded= command.ExecuteNonQuery();
            
        }
        catch (Exception e)
        {

            Console.WriteLine(e);
        }
            return RowsAdded;
        }       

        public DataTable GetTransferHistory(string fromState, DateTime fromDate, DateTime toDate)
        {
            DataTable table = new DataTable();
            //Implement code here. 
            //Do not change method signature
            return table;
        }
    }
}


