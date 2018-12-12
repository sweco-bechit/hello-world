using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DB = Autodesk.Revit.DB;
using UI = Autodesk.Revit.UI;
using UISelection = Autodesk.Revit.UI.Selection;

using RA = Autodesk.RevitAddIns;


namespace boydens.API.Revit
{
    public class HelloWorld : UI.IExternalCommand
    {
        public UI.Result Execute(UI.ExternalCommandData commandData, ref string message, DB.ElementSet elements)
        {
            UI.TaskDialog.Show("Hello", "Hello World!");
            return UI.Result.Succeeded;
        }
    }

    public class CreateManifest
    {
        //create a new addin manifest
        RA.RevitAddInManifest Manifest = new RA.RevitAddInManifest();

        ////create an external command
        //RA.RevitAddInCommand command1 = new RA.RevitAddInCommand("full path\assemblyName.dll", Guid.NewGuid(), "namespace.className", "boydens");
        //command1.Description = "description";
        //command1.Text = "display text";

        //// this command only visible in Revit MEP, Structure, and only visible 
        //// in Project document or when no document at all
        //command1.Discipline = Discipline.Mechanical | Discipline.Electrical |
        //                        Discipline.Piping | Discipline.Structure;
        //command1.VisibilityMode = VisibilityMode.NotVisibleInFamily;

        ////create an external application
        //RA.RevitAddInApplication application1 = new RA.RevitAddInApplication("appName",
        //    "full path\assemblyName.dll", Guid.NewGuid(), "namespace.className","boydens");

        ////add both command(s) and application(s) into manifest
        //Manifest.AddInCommands.Add(command1);
        //Manifest.AddInApplications.Add(application1);

        ////save manifest to a file
        //RA.RevitProduct revitProduct1 = RA.RevitProductUtility.GetAllInstalledRevitProducts()[0];
        //Manifest.SaveAs(revitProduct1.AllUsersAddInFolder + "\RevitAddInUtilitySample.addin");
    }
}

