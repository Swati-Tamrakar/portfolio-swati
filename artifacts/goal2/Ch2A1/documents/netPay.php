<?php
//Swati Tamrakar
    // get the data from the form
    $last= filter_input(INPUT_POST,'last');
    $first = filter_input(INPUT_POST,'first');
    $hoursWorked = filter_input(INPUT_POST, 'hoursWorked', FILTER_VALIDATE_FLOAT);
	$hourlyRate = filter_input(INPUT_POST,'hourlyRate', FILTER_VALIDATE_FLOAT);
	
	
	//define constants
	define('FED', 0.27);
	define('STATE', 0.15);
	define('FICA', 0.0765);
	define('RETIREMENT', 0.1);
	define('OVERTIME_PAY',1.5);
	define('WEEKHOURS', 40);

		//validate hours worked
	 if($hoursWorked === FALSE)
		{
			$errorMessage = 'The hours worked must be a valid number';
		}
	else if($hoursWorked <=0)
		{
			$errorMessage = "Please enter hours greater than zero.";
		}
	//validate hourly wage
	else if($hourlyRate === FALSE)
		{
			$errorMessage = 'The hourly rate must be a valid number';
		}
	else if($hourlyRate <=0)
		{
			$errorMessage = "Please enter your hourly wage.";
		}
		else {
        $errorMessage = ''; 
    }
	  // if an error message exists, go to the index page
	  
    if ($errorMessage != '') {
        include('../index.php');
        exit(); 
    }
	//calculate salary and overtime
	
	if ($hoursWorked <= WEEKHOURS)
	{
		$salary = $hourlyRate*$hoursWorked;
	}
	else  
		if ($hoursWorked > WEEKHOURS )
		{
			$regSalary  = WEEKHOURS * $hourlyRate;
			$overTime = $hoursWorked - WEEKHOURS;
			$overTimePay = $overTime*OVERTIME_PAY* $hourlyRate;
			$salary = $overTimePay+ $regSalary;
		}
    // apply currency formatting to the dollar and percent amounts
    //$salary_dp = "$".number_format($salary,2);
    // escape the unformatted input
    $first_escaped = htmlspecialchars($first);
	$last_escaped = htmlspecialchars($last);
	
?>
<!DOCTYPE html>
<html>
<!-- Swati Tamrakar -->
<head>
    <title>Hourly Salary Calculator </title>
    <link rel="stylesheet" type="text/css" href="/Ch2A1/styles/style.css">
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
</head>
<nav class = "hBar">
<ul>
  <li><a href="../index.php" class="active">Home</a></li>
  <li><a href = "../documents/aboutus.html" target ="blank">About us</a></li>
  <li><a href ="../documents/directory.html" target ="blank">Directory</a></li>
 </ul>
 <a href = "#" id= "icon"><img src = "/Ch2A1/images/navicon.png"/></a>
 </nav>
	<br>
	
<body>
    <main>
	<?php
		
	?>
        <h1>Net Salary Calculator <br>(Swati Tamrakar)</h1>
		<label>Name:</label>
        <span><?php echo ucfirst($last).", ". ucfirst($first); ?></span><br>

        <label>Gross Pay:</label>
        <span><?php echo "$".number_format($salary, 2); ?></span><br>

        <label>Federal Tax:</label>
        <span><?php 
		$federal = $salary* FED;
		echo "$".number_format($federal, 2); ?></span><br>

        <label>State Tax:</label>
        <span><?php 
		$state = $federal*STATE;
		echo "$".number_format($state, 2); ?></span><br>

        <label>FICA:</label>
        <span><?php 
		$fica = $salary * FICA;
		echo "$".number_format($fica, 2); ?></span><br>
		
        <label>Retirement:</label>
        <span><?php 
		$retirement = $salary * RETIREMENT;
		echo "$".number_format($retirement, 2); ?></span><br>

        <label>Total Deductions:</label>
        <span><?php 
		$deductions = $federal + $state + $fica + $retirement;
		echo "$".number_format($deductions, 2);?></span><br>

        <label>Net Pay:</label>
        <span><?php 
		$netPay =$salary - $deductions;
		echo "$".number_format($netPay, 2); ?></span><br>
    </main><br/>
    </main>
</body>
<br>
<footer>
		<address>
		   ZYX Computer Services 	&diams; 123 Somber St 	&diams; Wichita, KS 67534
		</address>
	</footer>
</html>