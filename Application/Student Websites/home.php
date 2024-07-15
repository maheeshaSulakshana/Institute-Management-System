<?php
    session_start();
    $stname = $_POST['studentname'];
    
    $id = $_SESSION['name'] ?? '';
?>

<html>
    <head>
        <Title>Students Portal</Title>

        <style>
            td{
                text-align: center;
            }

            #ribbon{
                font-size: 40px;
                font-weight: bold;
                width: 100%;
                height: 160px;
                background-color:mediumaquamarine;
                text-align: center;
            }

            table{
                position: relative;
                top: 50px;
            }

            button{
                width: 400px; 
                font-size: 50px;
            }
        </style>
    </head>

    <body>


        <!-- bootstrap -->
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Navbar</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                    <a class="nav-link" href="insertpage.php">Insert</a>
                    </li>
                    <li class="nav-item">
                    <a class="nav-link" href="update-page.php">Update</a>
                    </li>
                    <li class="nav-item">
                    <a class="nav-link" href = "delete-page.php" >Delete</a>
                    </li>
                </ul>
                </div>
            </div>
            </nav>
        <!-- Bootstarp -->


        <div id = "ribbon">
            Home Page
            <div style = "text-align: right; font-size: 30px">
                <?php echo 'Welcome '.$stname ?>
            </div>
            <div style = "text-align: right; font-size: 25px;">
                <a href="login-page.php" onclick="destroy()">LogOut</a>
            </div>
        </div>

        <table border = "0" align = "center" cellpadding = "6px">
            <tr>
                <td>
                    <form action="student-questions-page.php">
                        <button type = "submit">Ask Questions</button>
                    </form>
                </td>
                <td>
                    <form action="notes-page.php">
                        <button type = "submit">View Lecturer Notes</button>
                    </form>
                </td>
            </tr>

            <tr>
                <td>
                    <form action="mark-attendance-page.php">
                        <button type = "submit">Mark Attendance</button>
                    </form>
                </td>
                <td>
                    <form action="select-studentID-results.php">
                        <button type = "submit">View Results</button>
                    </form>
                </td>
            </tr>

            <tr>
                <td>
                    <form action="select-studentID-answers.php">
                        <button type = "submit">Answers</button>
                    </form>
                </td>
                <td>
                    <form action="select-studentID-schedule.php">
                        <button type = "submit">View Schedule</button>
                    </form>
                </td>
            </tr>

            <tr>
                <td>
                    <form action="insertpage.php">
                        <button type = "submit">Insert Student</button>
                    </form>
                </td>
                <td>
                    <form action="update-page.php">
                        <button type = "submit">Edit</button>
                    </form>
                </td>
            </tr>

            <tr>
                <td>
                    <form action="delete-page.php">
                        <button type = "submit">Delete</button>
                    </form>
                </td>
            </tr>
        </table>

        <script>
            function destroy(){
                <?php session_start();
                        if (isset($_SESSION['name'])){
                            session_destroy();
                        } ?>
            }
        </script>
    </body>
</html>