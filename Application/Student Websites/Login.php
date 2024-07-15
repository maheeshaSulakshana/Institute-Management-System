<?php 
   $st_name= $_POST['student_name'];
   $st_pw=$_POST['pass'];
    
   include_once 'DbConnection.php';
   $query= "select password from student_users where student_id='".$st_name."'";

   $result=mysqli_query($con, $query);
   $numberofrecords=mysqli_num_rows($result);
   session_start();
   $_session['name'] = $st_name;
?>

<html>
    <head>
    <title>Login Message</title>
    </head>
    <body>
        <?php if($numberofrecords==1){

        $record=mysqli_fetch_assoc($result);

        if($st_pw==$record['password']){?>
            <form action = 'home.php' method='POST'>
                <label>Login Successfull</label>
                <button type='Submit' >Continue </button>
                <input type = "text" name = "studentname" style = "display:none;" value="<?php echo $st_name ?>"> <?php echo $st_name;?>

            </form>
        <?php }else{?>
            <form action = 'login-page.php' method='POST'>
                <label>Login Unsuccessfull</label>
                <button type='Submit' >Go Back</button>
            </form>
        <?php }
        }
        else{
            echo('Student ID Is Wrong');
        } ?>
    </body>
</html>