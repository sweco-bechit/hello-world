using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DB = Autodesk.Revit.DB;
using UI = Autodesk.Revit.UI;
using UISelection = Autodesk.Revit.UI.Selection;


namespace boydens.API.Revit
{
    public class Element : UI.IExternalCommand
    {

        public UI.Result Execute(UI.ExternalCommandData commandData, ref string message, DB.ElementSet elements)

        {
            //Get application and documnet objects
            UI.UIApplication uiapp = commandData.Application;
            DB.Document doc = uiapp.ActiveUIDocument.Document;

            //Define a reference Object to accept the pick result
            DB.Reference pickedref = null;

            //Pick a group
            UISelection.Selection sel = uiapp.ActiveUIDocument.Selection;
            pickedref = sel.PickObject(UISelection.ObjectType.Element, "Please select a group");
            DB.Element elem = doc.GetElement(pickedref);
            DB.Group group = elem as DB.Group;

            //Pick point
            DB.XYZ point = sel.PickPoint("Please pick a point to place group");

            //Place the group
            DB.Transaction trans = new DB.Transaction(doc);
            trans.Start("Lab");
            doc.Create.PlaceGroup(point, group.GroupType);
            trans.Commit();
            return UI.Result.Succeeded;

        }

    }

}

