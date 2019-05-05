/*funkcja uruchamiana po przyciśnięciu przycisku */
function fiveSeconds(){
    setTimeout(alertPlay,5000);
}

/*funkcja alert uruchamiana po 5 sekundach*/
function alertPlay(){
    alert("Właśnie wycięto obszar wielkości 5 boisk futbolowych. Jeśli ten proces się nie zatrzyma, do 2022 zniknie cały las równikowy.");
}

function goToMenu(){
    window.location.assign("firstpage.html");
}

/*do jQuery - wysuwanie paneli */
$(document).ready(function(){
    $(".flip").click(function(){
      $(this).next().find(".panel").slideToggle("slow");
    });
  });