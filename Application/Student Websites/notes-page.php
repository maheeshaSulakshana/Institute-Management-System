<?php
    include_once 'DbConnection.php';

    $query = "Select * from Notes";

    $res = mysqli_query($con, $query);

    $no_of_rows = mysqli_num_rows($res);

    $c = 1;
?>

<html>
    <head>
        <title>View Notes</title>

        <style>
            table{
                table-layout: fixed;
                position: relative;
                top: 10px;
            }

            td{
                word-wrap: break-word;
            }
        </style>
    </head>

    <body>
        <table border = "1" width = "80%" cellpadding = "5px" cellspacing = "0px" align = "center">

            <tr>
                <th width = "20%">Note</th>
                <th width = "80%">Resource</th>
            </tr>

            <?php while ($c <= $no_of_rows){
                $row = mysqli_fetch_assoc($res); $c = $c + 1;
            ?>

                <tr>
                    <td> <?php echo $row['name']; ?> </td>
                    <td> <a href = "<?php echo $row['destination'] ?>" target = "_blank"> Click here to view note </a></td>
                </tr>

            <?php } ?>

        </table>
    </body>
</html>