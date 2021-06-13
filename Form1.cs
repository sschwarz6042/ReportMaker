using ReportMaker.Helpers;
using ReportMaker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportMaker
{
    public partial class Form1 : Form
    {
        private string docPath = Directory.GetCurrentDirectory();
        private string currentComponent = "visitorlogsbyvisitor";

        public Form1()
        {
            InitializeComponent();
        }

        private void ComponentButton_Click(object sender, EventArgs e)
        {
            string[] htmlLines;
            string[] tsLines = { "Also", "A", "Test" };


            string[] htmlTemplate = File.ReadAllLines("Templates\\HTML\\MainHTML.txt");
            string[] htmlOption1 = File.ReadAllLines("Templates\\HTML\\Option1.txt");

            //Add option 1 to correct position
            int OptionsIndex = 0;
            for(int i = 0; i < htmlTemplate.Length; i++)
            {
                if(htmlTemplate[i] == "<!--START OPTIONS-->")
                {
                    OptionsIndex = i+1;
                }
            }


            htmlLines = new string[htmlTemplate.Length + htmlOption1.Length];
            int tInd = 0;
            int oInd = 0;
            for(int i = 0; i < htmlLines.Length; i++)
            {
                if(i < OptionsIndex)
                {
                    htmlLines[i] = htmlTemplate[tInd];
                    tInd++;
                }
                else if (i >= OptionsIndex)
                {
                    if(i >= OptionsIndex + htmlOption1.Length)
                    {
                        htmlLines[i] = htmlTemplate[tInd];
                        tInd++;
                    }
                    else
                    {
                        htmlLines[i] = htmlOption1[oInd];
                        oInd++;
                    }
                }
            }

            CreateHTMLFile(currentComponent, htmlLines);
            CreateTSFile(currentComponent, tsLines);


        }

        private void CreateHTMLFile(string componentName, string[] lines)
        {
            string htmlName = componentName + ".component.html";

            //Create HTML File
            using (StreamWriter htmlFile = new StreamWriter(Path.Combine(docPath, htmlName), true))
            {
                foreach (string line in lines)
                {
                    htmlFile.WriteLine(line);
                }
            }
        }


        private void CreateTSFile(string componentName, string[] lines)
        {
            string tsName = currentComponent + ".component.ts";

            //Create Typescript File
            using (StreamWriter tsFile = new StreamWriter(Path.Combine(docPath, tsName), true))
            {
                foreach (string line in lines)
                {
                    tsFile.WriteLine(line);
                }
            }
        }

        private void ExcelFilePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ExcelFilePathTextBox.Text = ofd.FileName;
            }
        }

        private void OutputDirectoryPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                OutputDirectoryPathTextBox.Text = fbd.SelectedPath;
            }
        }

        private void CreateFromExcelButton_Click(object sender, EventArgs e)
        {
            string outputPath = "";
            //Pick output path
            if(OutputDirectoryPathTextBox.Text != "")
            {
                outputPath = OutputDirectoryPathTextBox.Text;
            }


            //Try to parse the data from the excel file
            Console.WriteLine("\nGetting Report Models From file\n");
            List<ReportModel> reportModels = Parser.GetReportModelsFromCSV(ExcelFilePathTextBox.Text);

            //
            //Testing Parser
            //
            Console.WriteLine("\nPrinting Out {0} Report Models\n", reportModels.Count);
            for(int i = 0; i < reportModels.Count; i++)
            {
                Console.WriteLine("Entry: {0}\nName: {1}\nFinished: {2}\nReportID: {3}", i, reportModels[i].ReportName, reportModels[i].Finished, reportModels[i].ReportID);
                for(int j = 0; j < reportModels[i].Parameters.Count; j++)
                {
                    Console.WriteLine("Parameter {0}: {1}", j, reportModels[i].Parameters[j].ParamCaptionLeft);
                }
                Console.WriteLine();
            }

            //Create a list of ReportModels from the excel data
            //Create one textfile that has C# MenuItems for all of the components

            //For each component:
            //Create Folder for each component
            //Use HTML Generator to make the html file for that item
            for(int i = 0; i < reportModels.Count; i++)
            {
                if (!reportModels[i].Finished)
                {
                    HTMLGenerator.GenerateHTMLFromReportModel(outputPath, reportModels[i]);
                }
            }

            //Create services for all of the parameters that need one
            AngularGenerator.GenerateServicesFromReportModels(outputPath, reportModels);

            //Use Angular Generator to make the ts file for that item
            for (int i = 0; i < reportModels.Count; i++)
            {
                if (!reportModels[i].Finished)
                {
                    AngularGenerator.GenerateAngularFromReportModel(outputPath, reportModels[i]);
                }
            }

            //Create links
            string textFileName = "SecurityData.csLinks.txt";
            using (StreamWriter textFile = new StreamWriter(Path.Combine(outputPath, textFileName), true))
            {
                foreach(var rm in reportModels)
                {
                    textFile.WriteLine(MenuItemGenerator.CreateSecurityDataMenuItem(rm.ReportName));
                }
            }

            textFileName = "Index.ts.txt";
            using (StreamWriter textFile = new StreamWriter(Path.Combine(outputPath, textFileName), true))
            {
                foreach (var rm in reportModels)
                {
                    textFile.WriteLine(MenuItemGenerator.CreateIndexTSLinks(rm.ReportName));
                }
            }
            textFileName = "report-routes.ts.txt";
            using (StreamWriter textFile = new StreamWriter(Path.Combine(outputPath, textFileName), true))
            {
                foreach (var rm in reportModels)
                {
                    textFile.WriteLine(MenuItemGenerator.CreateReportRouteLinks(rm.ReportName));
                }
            }
        }
    }
}
    