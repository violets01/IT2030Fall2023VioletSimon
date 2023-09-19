<!DOCTYPE html>
<html>
<body>

<h2>Corrections</h2>
<ol>
  <li>Models\TipCalculator.cs 
    <ol>
      <li>A ; was missed</li>
    </ol>
  <li>Controllers\Homecontroller.cs
    <ol>
      <li>ViewBag.Twentyfive. “B” was not capitalized</li> 
      <li>Needed to add return to line 18</li>
    </ol>
  <li>Views\Home\Index.cshtml 
    <ol>
    <li><label>@ViewBag.Fifteen.ToString("c2")</label> fifteen was misspelled</li>
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


