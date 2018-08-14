﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace PullFromCloudFeat
{
    class CloudPull
    {
        //Do not change these 3 lines unless it is just changing the names of the objects. These lines are the connection to the cloud
        readonly static CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tealseeboateeststorage;AccountKey=<insertKeyHere>;EndpointSuffix=core.windows.net");
        readonly static CloudTableClient tableClient = cloudStorageAccount.CreateCloudTableClient();
        CloudTable dummyDataTable = tableClient.GetTableReference("TestSeeboatData");

        //This method isn't tested feel free to change if needed
        public bool PullFromCloud()
        {
            try
            {
                TableBatchOperation operatorPullingFromCloud = new TableBatchOperation();
                List<TableEntity> tableEntities = new List<TableEntity>();
                operatorPullingFromCloud.Add(TableOperation.Retrieve("TestBoat1", "001", null));
                operatorPullingFromCloud.Add(TableOperation.Retrieve("TestBoat1", "002", null));
                dummyDataTable.ExecuteBatchAsync(operatorPullingFromCloud).RunSynchronously();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Use this to test if the connection to the cloud works 
        public bool DoesTableExist()
        {
            return dummyDataTable.ExistsAsync().Result;
        }
    }
}
