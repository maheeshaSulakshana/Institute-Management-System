<?php 
    include_once 'DbConnection.php';

    $studentID = $_POST['studentID'];

    $query = "Select QuestionID, Question, Answer from Q_A where StudentID = ".$studentID."";

    $res = mysqli_query($con, $query);

    $no_of_rows = mysqli_num_rows($res);

    $c = 1;
?>


<html>
    <head>
        <Title>Answers</Title>

        <style>
            table{
                table-layout: fixed;
            }

            td{
                word-wrap: break-word;
            }
        </style>
    </head>

    <body>
        <table border = "1" cellspacing = "0px" cellpadding = "5px" align = "center" width = "70%">
            <tr>
                <th width = "10%">Question ID</th>
                <th width = "45%">Question</th>
                <th width = "45%">Answer</th>
            </tr>

            <?php while ($c <= $no_of_rows){
                $record = mysqli_fetch_assoc($res);
                $c = $c + 1; ?>

            <tr>
                <td>
                    <?php echo $record['QuestionID']; ?>
                </td>
                <td>
                    <?php echo $record['Question']; ?>
                </td>
                <td>
                    <?php if($record['Answer']){
                        echo $record['Answer'];
                    } else {
                            echo "Sir has not answered this question yet";
                    }?>
                </td>
            </tr>

            <?php } ?>
        </table>
    </body>
</html>