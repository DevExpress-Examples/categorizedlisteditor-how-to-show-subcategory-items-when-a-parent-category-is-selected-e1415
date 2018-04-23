﻿// Developer Express Code Central Example:
// How to show items of the child categories in the list of items of the parent category when using the CategorizedListEditor
// 
// The CategorizedListEditor consist of two views - the tree list of the categories
// in the left area of the editor (CategoriesListView), and the list of categorized
// items on the right (GridView). Items in the GridView are filtered by category,
// selected in the CategoriesListView. If the selected category has children, items
// belonging to them won't be shown in the GridView. This example demonstrates, how
// to change this behavior, and filter GridView to show all items of the selected
// category and its children. See Also: Implement the ICategorizedItem Interface
// Use the Built-in HCategory Class How to: Implement a Custom Windows Forms List
// Editor
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1415

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WinSample.Module.Win")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("-")]
[assembly: AssemblyProduct("WinSample.Module.Win")]
[assembly: AssemblyCopyright("Copyright � - 2007")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.*")]

