﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_s_Lending_Administration.Data.SetUp
{
    public class SetUpCDs
    {
        public SetUpCDs()
        {
            if (!File.Exists(StartForm.filePathCDs))
            {
                // Create the file if it doesn't exist
                using (StreamWriter writer = new StreamWriter(StartForm.filePathCDs))
                {
                    // Write the header
                    writer.WriteLine("Id,Title,Discription,Author, Max_Days_for_Lending, RendingDate, Status_for_Lending");
                    writer.WriteLine("2c50360b-6e4d-46b7-8905-9e19d82cbb04,Children for Coding,A learning book for CDs - available online,Michell Cronberg,30,26-04-2024,Home");

                }
            }
        }
    }
}
