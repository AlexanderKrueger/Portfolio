/* ---DEPENDENCYS ---
 * jquery
 */

//
//--- VARIABLES ---
//
var driverTable = $("#driver-table");

//*** Object Definitions ***
//object definiton: driver
var driver;
//_________property_			___default value___			___description___
driver.prototype.firstName              = "";                                   //Drivers first name
driver.prototype.lastName               = "";                                   //Drivers last name
driver.prototype.isShown                = false;                                //Determines if driver's first and last name are shown
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//object functions
driver.prototype.toggleShown
= function()
{
  this.isShown = !this.isShown;
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//object constructor
function driver
(
  newFirstName,
  newLastName
)
{
  this.firstName = newFirstName;
  this.lastName = newLastName;
}

//*** Driver Array ***
driverList =
[
  new driver("Alexander", "Keplar"),
  new driver("Paul", "Blocks"),
  new driver("Mark", "Walberg"),
  new driver("Hoverboard", "Tim"),
  new driver("Tom", "Tom"),
  new driver("Garmin", "Wallowits"),
  new driver("Tim", "Bob"),
  new driver("Big", "Bob"),
  new driver("Paul", "Walker"),
  new driver("Mark", "Tucker"),
  new driver("Linda", "Grace"),
  new driver("Jason", "Holtz"),
  new driver("Donald", "Trump"),
  new driver("Allen", "Harpper"),
  new driver("Ronald", "Thor"),
  new driver("Thitz", "Newman"),
  new driver("Darth", "Vader"),
  new driver("Paul", "Allen"),
  new driver("Jason", "Tucker"),
  new driver("Tom", "Clark"),
  new driver("Bill", "Bates"),
  new driver("Timothy", "Regan"),
  new driver("Sam", "Boltz"),
  new driver("Cam", "Fisher"),
  new driver("Fox", "Huston"),
  new driver("Philip", "Auston"),
  new driver("Morgan", "Freeman"),
  new driver("Blitz", "Bait"),
  new driver("Holten", "Craige"),
  new driver("Fuzz", "Ball"),
  new driver("Anthony", "Gibs"),
  new driver("Richerd", "Blake"),
  new driver("Charles", "Hopper"),
  new driver("James", "Furgason"),
  new driver("Gibbson", "Thorton"),
  new driver("Jacob", "Fin"),
  new driver("Bob", "Smith"),
  new driver("Frier", "Crisp"),
  new driver("Don", "Noble"),
  new driver("Wallace", "Wake"),
  new driver("Blitzer", "Normandy"),
  new driver("Tercero", "Horace"),
  new driver("Kristoffer", "Lalo"),
  new driver("Lewis", "Derik"),
  new driver("Micky", "Emirhan"),
  new driver("Knox", "Ivery"),
  new driver("Lindy", "Harald"),
  new driver("Last", "Driver")
];

//
//Functions: Visibility of drivers on list
//

//randomly toggles vissibility of all drivers in the 'driverList'
function randomlyToggleAllDrivers()
{
  var arrayLength = driverList.length  - 1;
  
  //for each element of 'diverList'
  for(var curIndex = 0; curIndex < arrayLength; curIndex++)
  {
    //if random selection from range (1-0) == 1
    if(Math.round(Math.random()) == 1)
    {
      driverList[curIndex].toggleShown();
    }
  }
}

function fillDriverTable()
{
    var driverListLength = driverList.length;
    
    for(var i = 0; i < driverListLength; i++)
        {
            $("#driver-table").append("<tr id='driver-table-row-" + i + "'><td>" + driverList[i].firstName + " " + driverList[i].lastName + "</td></tr>");  
        }
}
function updateDriverTable()
{
  randomlyToggleAllDrivers();
  
  var driverListLength = driverList.length;
    
  for(var i = 0; i < driverListLength; i++)
      {
          if(driverList[i].isShown == false)
              {
                $("#driver-table-row-" + i).slideUp("slow");  
              }
          else
              {
                  $("#driver-table-row-" + i).slideDown("slow");
              }
      }
}

//---Event Trigger---
$(document).ready(
function(){ fillDriverTable();
driverTable.click(
function()
{
    //use set time interval?
    updateDriverTable();
})
}
);