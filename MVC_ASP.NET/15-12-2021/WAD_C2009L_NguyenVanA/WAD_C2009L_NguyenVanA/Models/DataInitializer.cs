using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    //Database Initializer(Code First)
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {
            base.InitializeDatabase(context);
            //Seed(context);

        }
        protected override void Seed(DataContext context)
        {
            /*
                Enable-Migrations    
                Enable-Migrations -ContextTypeName WAD_C2009L_NguyenVanA.Models.DataContext 
                add-migration Initial
                update-database
             */

            //ko dung cau lenh sql
            
        }
    }
}