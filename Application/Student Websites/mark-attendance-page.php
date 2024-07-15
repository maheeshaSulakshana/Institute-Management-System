<?php
    include_once 'DbConnection.php';

    $query = "Select distinct studentID from student_courses";
    $studentIDs = mysqli_query($con, $query);
    $no_studentIDs = mysqli_num_rows($studentIDs);


    $query = "Select distinct courseID from student_courses";
    $courseIDs = mysqli_query($con, $query);
    $no_courseIDs = mysqli_num_rows($courseIDs);

    $c = 1;

    date_default_timezone_set('Asia/Colombo');

    $time = date("h");
?>

<html>
    <head>
        <title>Attendance Marking Page</title>

        <style>
            select{
                width : 100px;
            }

            table{
                position: relative;
                top: 100px;
            }

            td{
                text-align: center;
                font-family: 'Times New Roman', Times, sans-serif;
                font-size: 40px;
            }

            select{
                font-size: 40px;
                font-family: monospace;
            }

            button{
                font-size: 40px;
                font-family: 'Times New Roman', Times, serif;
                background-color: whitesmoke;
            }

            div{
                background-color: bisque;
                width: 100%;
                height: 100px;
                text-align: center;
                font-size: 40px;
                font-family: 'Times New Roman', Times, sans-serif;
                font-weight: bold;
            }
        </style>
    </head>

    <body>
        <div>
            Mark Student Attendance
        </div>
        <table border = "1" width = "75%" align = "center" cellspacing = "0px" cellpadding = "10px">
            <tr>
                <td>
                    <form action="mark-attendance.php" method = "POST">
                        <br>
                        <label for="studentID">Please select your studentID</label>
                        <select name = "studentID">
                            <?php while ($c <= $no_studentIDs) {
                                $row = mysqli_fetch_assoc($studentIDs);
                                $c = $c + 1; ?>

                                <option value = " <?php echo $row['studentID'] ?>">
                                    <?php echo $row['studentID'] ?> 
                                </option>

                            <?php } $c = 1;?>
                        </select> <br> <br>

                        <label for="courseID">Please select your courseID</label>
                        <select name = "courseID">
                            <?php while ($c <= $no_courseIDs) {
                                $row = mysqli_fetch_assoc($courseIDs);
                                $c = $c + 1; ?>

                                <option value = " <?php echo $row['courseID'] ?>">
                                    <?php echo $row['courseID'] ?> 
                                </option>

                            <?php } ?>
                        </select> <br> <br>

                        <button type = "submit">Mark Attendance</button>
                    </form>
                </td>
            </tr>
        </table>
    </body>
</html>