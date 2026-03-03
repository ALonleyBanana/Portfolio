<?php require_once(__DIR__ . "/partials/nav.php"); ?>
<html>
  <head>
    <title> Create </title>
    <link rel="stylesheet" type="text/css" href="style.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
  </head>
  <body>
    <form>
      <div class="form-group">
        <label for="compTitle">Competiton Name</label>
        <input type="compTitle" class="form-control" id="compTitle" aria-describedby="username" placeholder="Enter Title">
      </div>
      <div class="form-group">
        <label for="minPart">Minimum Participants</label>
        <input type="minPart" class="form-control" id="minPart" placeholder="Password">
      </div>
      <button type="submit" class="btn btn-primary">Submit</button>
    </form>
  </body>
</html>
<?php require(__DIR__ . "/partials/flash.php"); ?>