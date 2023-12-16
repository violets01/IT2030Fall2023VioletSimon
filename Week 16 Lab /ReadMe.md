<!DOCTYPE html>
<html>
<body>

<h2>Week 16 responses.</h2>
<ol>
  <li>List 3 things that you learned in this class.  
    <ol>
      <li>MVC Architecture: ASP.Net Core MVC separates a web application into 3 components: Model, which represents the data. 
        View that displays the user interface. And finally, the Controller, which handles input and the flow of data between 
        the Model and the View. </li>
      <li>Razor Pages: This feature allows developers to create a web page using a combination of HTML and C#. It makes the process of 
        development much simpler and easier to maintain. </li>
      <li>Entity Framework Core: This framework provided by Microsoft enables developers to work with databases using OO techniques. 
        This takes away the need to write raw SQL queries. Making me question why I spent weeks of my life learning how to write them. </li>
    </ol>
  <li>Controllers\Homecontroller.cs
    <ol>
      <li>ViewBag.Twentyfive. “B” was not capitalized.</li> 
      <li>Needed to add return to line 18.</li>
    </ol>
  <li>Views\Home\Index.cshtml 
    <ol>
    <li><label>@ViewBag.Fifteen.ToString("c2")</label> fifteen was misspelled.</li>
    </ol>
  <li>Models\TipCalculator.cs (Fixing the calculation)
    <ol>
    <li>Originally the tip was set to = the cost of the meal divided by the percent of the tip, it needs to be multiplied by the percent in order to get the value of the tip.</li>
    </ol>
  <li>wwwroot\css\site.css (CSS error) 
    <ol>
    <li>The issue was that width was misspelled. </li>
    </ol>
</ol>

</body>
</html>
