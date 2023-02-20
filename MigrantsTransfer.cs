using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrantsTransferTrackerBLL      //DO NOT change the namespace name
{
    public class MigrantsTransfer   //DO NOT change the class name
    {
        //Implement the properties here
        public DateTime TransferDate;
        public string FromState;
        public string ToState;
        public int NoOfMigrantsTransfered;
        public string TransferMode;
        public string VehicleDetails;
        //Implement default and 6 parameterized constructor

        public MigrantsTransfer() { }

        public MigrantsTransfer(DateTime transferDate,
                                      string fromState,
                                      string toState,
                                      int noOfMigrantsTransfered,
                                      string transferMode,
                                      string vehicleDetails)
        {
            this.TransferDate = transferDate;
            this.FromState = fromState;
            this.ToState = toState;
            this.NoOfMigrantsTransfered = noOfMigrantsTransfered;
            this.TransferMode = transferMode;
            this.VehicleDetails = vehicleDetails;
        }

    }
}
