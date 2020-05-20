<?php
include("../configonline.php");
$total=mysqli_query($con,"Select produk_id, nama_produk, tanggal, stok, kota, jam, genre
from produk WHERE PRODUK_ID NOT IN (SELECT PRODUK_ID FROM cart_produk c GROUP BY PRODUK_ID);
");
$dropdown=mysqli_query($con,"SELECT kota FROM produk p group by kota;");
$dropdown2=mysqli_query($con,"SELECT * FROM kategori k;");
if($_GET){
  if(isset($_GET['kota'])){
    $kota="and kota$_GET[kota]";
    
  }
   if(isset($_GET['kategori'])){
    $kategori="and kategori_id='$_GET[kategori]'";
    
  }
  if(isset($_GET['stok'])){
    $stok="order by stok $_GET[stok]";
    
  }
  
  $query_utama = "Select produk_id, nama_produk, tanggal, stok, kota, jam, genre
  from produk WHERE PRODUK_ID NOT IN (SELECT PRODUK_ID FROM cart_produk c GROUP BY PRODUK_ID)".$kota.$kategori.$stok;
  $total=mysqli_query($con,$query_utama);
  
  };


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
  <nav class="navbar navbar-inverse navbar-fixed-top">
    <div class="container-fluid">
      <div class="navbar-header">
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar"
          aria-expanded="false" aria-controls="navbar">
          <span class="sr-only">Toggle navigation</span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
          <span class="icon-bar"></span>
        </button>
        <a class="navbar-brand" href="#">MyCons Est. 2019</a>
      </div>

    </div>
  </nav>
  <div id='a'>

  </div>


  <div class="container-fluid">
    <div class="row">
      <?php include("sidebar.php")?>
      <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main" style="position: relative;margin-top:-750px">
        <h1 class="page-header">Produk yang Belum pernah Dibeli</h1>
        <form action="" method="get">
          <div class=" col-md-4 " style="position: relative;">
          <h3>KATEGORI</h3>
            <div class="btn-group" role="group">

              <?php while ($tampung2=mysqli_fetch_assoc($dropdown2)): ?>
              <input type="radio" style="display:inline;" name="kategori"
                value="<?php echo $tampung2['kategori_id'] ?>">
              <?php echo $tampung2['nama_kategori'] ?><br>
              <?php endwhile ;?>

            </div>

          </div>
          <div class=" col-md-4 " style="position: relative;">




          <h3>KOTA</h3>

            <select name="kota" id="">
              <option value="!=''">kota</option>
              <?php while ($tampung=mysqli_fetch_assoc($dropdown)): ?>
              <option value="='<?php echo $tampung['kota'] ?>'"> <?php echo $tampung['kota'] ?></option>
              <?php endwhile ;?>
            </select>



          </div>
          <div class=" col-md-4 " style="position: relative">
<h3>STOK</h3>
            <div class="btn-group" role="group">

              <select name="stok" id="">
                <option value="asc">terkecil</option>
                <option value="desc">terbesar</option>
              </select>

            </div>

          </div>
          <button style="width:100px;height:50px;margin-left:80%" type="submit">Cari</button>
        </form>


        <div class="table-responsive col-md-12">
          <table class="table table-striped">
            <thead>
              <tr>
                <th>PRODUK ID</th>
                <th>NAMA PRODUK</th>
                <th>TANGGAL</th>
                <th>STOK</th>
                <th>KOTA</th>
                <th>JAM</th>
                <th>GENRE</th>
              </tr>
            </thead>
            <tbody>
              <?php while($tampung=mysqli_fetch_assoc($total)): ?>
              <tr>
                <td><?php echo $tampung['produk_id']   ?></td>
                <td><?php echo $tampung['nama_produk']   ?></td>

                <td><?php echo $tampung['tanggal']   ?></td>
                <td><?php echo $tampung['stok']   ?></td>
                <td><?php echo $tampung['kota']   ?></td>
                <td><?php echo $tampung['jam']   ?></td>
                <td><?php echo $tampung['genre']   ?></td>

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
  <script>
    window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')
  </script>
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