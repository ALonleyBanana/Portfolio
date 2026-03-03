



<?php require_once(__DIR__ . "/partials/nav.php"); ?>
<head>

<title>tev5's Arcade!</title>

</head>
<body>

<h1> Tev5's Arcade! </h1>
<h2> Games </h2>
  <a href="snake.php"> snake </a>
<?php if(!is_logged_in):?>
  <p> Please Log in to view scores </p>
<?php endif; ?>

</body>

<?php require(__DIR__ . "/partials/flash.php");?>