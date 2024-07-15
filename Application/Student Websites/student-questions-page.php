<?php
    include_once 'DbConnection.php';

    $query = "Select studentid from students";

    $res = mysqli_query($con, $query);
    
    $no_rows = mysqli_num_rows($res);
    
    $c = 1;
?>

<html>
    <head>
        <Title>Ask Questions</Title>

        <link rel="stylesheet" href = "stylings.css"/>
    </head>

    <body style = "display: none;">
        <h1 id = "heading">Feel free to ask any Question you have regarding you're studies</h1>
        <table cellspacing = "0px" cellpadding = "5px" align = "center">

            <tr>
                <td id = "Title">Ask Questions</td>
            </tr>

            <!--Question form-->
            <tr>
                <td>
                    <form action="save-questions.php" method = "POST">
                        <!--Label and ComboBox to select StudentID to submit question-->
                        <label for="studentID">Student ID</label>
                        <select required name = "studentID">
                            <option value="">Please Select StudentID</option>
                            <?php while ( $c <= $no_rows ) {$row = mysqli_fetch_assoc($res);?>
                                <option value = '<?php echo $row['studentid'];?>'>
                                    <?php echo $row['studentid'];?>
                                </option>
                            <?php $c = $c + 1; } ?>
                        </select> <br> <br>
                        

                        <!--Label and TextArea to note the question-->
                        <label for="question">Question</label> <br>
                        <textarea required rows = "10" cols = "40" name = "question"></textarea> <br><br>

                        <!--Button to submit question-->
                        <button type = "Submit" name = "submit" id = "submit">
                            Submit
                        </button>
                    </form>
                </td>
            </tr>

        </table>

        <script src = "JQuery.js"></script>
        <script>
            $(function(){
                $('body').fadeIn(1000);
            });
        </script>
    </body>
</html>