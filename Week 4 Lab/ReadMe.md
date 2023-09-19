<!DOCTYPE html>
<html>
<body>

<h2>Corrections</h2>
<ol>
  <li>models\TipCalculator.cs 
    <ol>
    <li>A ; was missed</li>
  <li>Controllers\Homecontroller.cs
      <li>ViewBag.Twentyfive. “B” was not capitalized</li>  
    </ol>
  </li>
  <li>Milk</li>
</ol>

</body>
</html>

1.)models\TipCalculator.cs 
  a.A ; was missed 
2.)Controllers\Homecontroller.cs

Needed to add return to line 18 
Views\Home\Index.cshtml 
<label>@ViewBag.Fifteen.ToString("c2")</label> fifteen was misspelled 
Models\TipCalculator.cs (Fixing the calculation)
Originally the tip was set to = the cost of the meal divided by the percent of the tip, it needs to be multiplied by the percent in order to get the value of the tip
wwwroot\css\site.css (CSS error) 
The issue was that width was misspelled.  
