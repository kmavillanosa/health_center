using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter
{
    public class ExcelReports
    {

        public static void GemerateParticipantEvent(PersonEvents ev)
        {
            using(var workbook = new XLWorkbook())
            {

                var ws = workbook.Worksheets.Add(ev.Title);
                var colIndex = 1;
                var rowIndex = 2;

                ws.Cell(1, colIndex).Value = "FullName";
                ws.Cell(1, colIndex + 1).Value = "Date filed";
                ws.Cell(1, colIndex + 2).Value = "Ailment detail";
                ws.Cell(1, colIndex + 3).Value = "Diagnosis";
                ws.Cell(1, colIndex + 4).Value = "Remarks";

                ws.Cell(1, colIndex + 5).Value = "Weight";
                ws.Cell(1, colIndex + 6).Value = "Height";
                ws.Cell(1, colIndex + 7).Value = "ExpectedChildGender";
                ws.Cell(1, colIndex + 8).Value = "PregnancyDueDate";


                foreach (var log in ev.Logs)
                {
                    ws.Cell(rowIndex, colIndex).Value = log.FullName;
                    ws.Cell(rowIndex, colIndex + 1).Value = log.LastModified;
                    if (log.Consultation != null)
                    {
                        ws.Cell(rowIndex, colIndex + 2).Value = log.Consultation.AilmentDetail;
                        ws.Cell(rowIndex, colIndex + 3).Value = log.Consultation.Diagnosis;
                        ws.Cell(rowIndex, colIndex + 4).Value = log.Consultation.Remarks;

                        ws.Cell(rowIndex, colIndex + 5).Value = log.Consultation.Weight;
                        ws.Cell(rowIndex, colIndex + 6).Value = log.Consultation.Height;
                        ws.Cell(rowIndex, colIndex + 7).Value = log.Consultation.ExpectedChildGender;
                        ws.Cell(rowIndex, colIndex + 8).Value = log.Consultation.PregnancyDueDate;

                    }
                    rowIndex++;
                }


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files | *.xlsx";
                sfd.DefaultExt = "xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Saved");
                }
            }
        }


        public static void GenerateEventParticipants(List<PersonEvents> events)
        {
            using (var workbook = new XLWorkbook())
            {

                foreach (var ev in events)
                {
                    var ws = workbook.Worksheets.Add(ev.Title);
                    var colIndex = 1;
                    var rowIndex = 2;

                    ws.Cell(1, colIndex).Value = "FullName";
                    ws.Cell(1, colIndex + 1).Value = "Date filed";
                    ws.Cell(1, colIndex + 2).Value = "Ailment detail";
                    ws.Cell(1, colIndex + 3).Value = "Diagnosis";
                    ws.Cell(1, colIndex + 4).Value = "Remarks";

                    ws.Cell(1, colIndex + 5).Value = "Weight";
                    ws.Cell(1, colIndex + 6).Value = "Height";
                    ws.Cell(1, colIndex + 7).Value = "ExpectedChildGender";
                    ws.Cell(1, colIndex + 8).Value = "PregnancyDueDate";


                    foreach (var log in ev.Logs)
                    {
                        ws.Cell(rowIndex, colIndex).Value = log.FullName;
                        ws.Cell(rowIndex, colIndex + 1).Value = log.LastModified;
                        if (log.Consultation != null)
                        {
                            ws.Cell(rowIndex, colIndex + 2).Value = log.Consultation.AilmentDetail;
                            ws.Cell(rowIndex, colIndex + 3).Value = log.Consultation.Diagnosis;
                            ws.Cell(rowIndex, colIndex + 4).Value = log.Consultation.Remarks;

                            ws.Cell(rowIndex, colIndex + 5).Value = log.Consultation.Weight;
                            ws.Cell(rowIndex, colIndex + 6).Value = log.Consultation.Height;
                            ws.Cell(rowIndex, colIndex + 7).Value = log.Consultation.ExpectedChildGender;
                            ws.Cell(rowIndex, colIndex + 8).Value = log.Consultation.PregnancyDueDate;

                        }
                        rowIndex++;

                    }

                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files | *.xlsx";
                sfd.DefaultExt = "xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Saved");
                }

            }
        }

        public static void GeneratePersonReport(Person data)
        {
            using (var workbook = new XLWorkbook())
            {

                var ws = workbook.Worksheets.Add("Person Record");
                var colIndex = 1;
                var rowIndex = 3;

                ws.Cell(1, colIndex).Value = data.FullName;
                ws.Cell(1, colIndex + 1).Value = data.Gender;
                ws.Cell(1, colIndex + 2).Value = data.PersonCategory;
                ws.Cell(1, colIndex + 3).Value = data.Address;
                ws.Cell(1, colIndex + 4).Value = data.LastModified;


                ws.Cell(2, colIndex).Value = "AilmentDetail";
                ws.Cell(2, colIndex + 1).Value = "Diagnosis";
                ws.Cell(2, colIndex + 2).Value = "Remarks";
                ws.Cell(2, colIndex + 3).Value = "Date Filed";

                foreach (var cons in data.Consultations)
                {
                    ws.Cell(rowIndex, colIndex).Value = cons.AilmentDetail;
                    ws.Cell(rowIndex, colIndex + 1).Value = cons.Diagnosis;
                    ws.Cell(rowIndex, colIndex + 2).Value = cons.Remarks;
                    ws.Cell(rowIndex, colIndex + 3).Value = cons.LastModified;
                    rowIndex++;

                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files | *.xlsx";
                sfd.DefaultExt = "xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Saved");
                }
            }
        }
    }
}
