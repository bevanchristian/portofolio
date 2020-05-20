<?php
include("../configonline.php");
$total=mysqli_query($con, " select nama_penyelenggara,count(nama_produk) as 'uu' from produk p ,penyelenggara pl,penyelenggara_produk pp where p.produk_id=pp.produk_id and pl.penyelenggara_id=pp.penyelenggara_id group by nama_penyelenggara;");


?>

<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="../assets/bootstrap/css/bootstrap.css" rel="stylesheet">
      
        <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
        <meta name="description" content="">
        <meta name="author" content="">
        <link rel="icon" href="../../favicon.ico">
        <link rel="canonical" href="https://getbootstrap.com/docs/3.3/examples/dashboard/">
    
        <title>Dashboard Template for Bootstrap</title>
    
        
      </head>
    <body>
    <?php echo include('logo.html');?>
  
        <div style="position:relative;top:-100px;margin-bottom:0px" id='a' >
    
    </div>
        <div class="container-fluid">
          <div class="row">
          <?php include("sidebar.php")?>
            <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main"style="position: relative;margin-top:-750px">
              <h1 class="page-header">konser yang dimiliki penyelengara</h1>


    
              
              <div class="table-responsive">
                <table class="table table-striped">
                  <thead>
                    <tr>
                      <th>penyelengara</th>
                      <th>jumlah konser yang dimiliki</th>
                 
                    </tr>
                  </thead>
                  <tbody>
                    <?php while($tampung=mysqli_fetch_assoc($total)): ?>
                    <tr>
                    
                      <td><?php echo $tampung['nama_penyelenggara']   ?></td> 
                      <td><?php echo $tampung['uu']   ?></td>
                    </tr>
                    <?php endwhile; ?>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
    
        <!-- Bootstrap core JavaScript
        ================================================== -->
        <!-- Placed at the end of the document so the pages load faster -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
        <script src="../../dist/js/bootstrap.min.js"></script>
        <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
        <script src="../../assets/js/vendor/holder.min.js"></script>
        <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
        <script src="../../assets/js/ie10-viewport-bug-workaround.js"></script>
      
        <script src="../assets/script/jquery-3.4.1.min.js"></script>
        <script src="../assets/bootstrap/js/bootstrap.js"></script>
        <script src="script.js"></script>
    </body>
</html>