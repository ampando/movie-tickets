//name of a movie
//time of day for movie showing
//age of the person
//cost of the ticket
  //senior ticket cost
  //matinee cost
  //non first release cost
  //child ticket cost
  //standard ticket cost

//Constructor Ticket 
//Prototype Ticket

//Determine cost based on user input

function Ticket(movie, showTime, age) {
  this.movie = movie;
  this.showTime = showTime;
  this.age = age;
}





//let ageCheckResult = 0;
Ticket.prototype.ageCheck = function() {
  let ageCheckResult;
  if(this.age >= 65) {
    ageCheckResult = "senior";
  } else if(this.age <= 12) {
    ageCheckResult = "child"
  } else {
    ageCheckResult = "standard"
  }
  return ageCheckResult;
}



Ticket.prototype.movieTime = function() {
  //let movieTimeResult;
  if(this.showTime < 5) {
    return "matinee"
  } else if (this.showTime >= 5) {
    return "regular"
  } else {
    return false
  }
}


Ticket.prototype.ticketCost = function() {
  if(this.ageCheck() === "standard" && this.movieTime() === "regular") {
    return 13;
  } else if (this.ageCheck() === "child" && this.movieTime() === "regular" || "matinee") {
    return 7;
  } else if (this.ageCheck() === "senior" && this.movieTime() === "regular" || "matinee") {
    return 7;
  } else if (this.ageCheck() === "standard" && this.movieTime() === "matinee") {
    return 7;
  }
};


//UI Logic 

$(document).ready(function(){
  $("#form-one").submit(function(event){
    event.preventDefault();
    const inputtedMovieTime = $("#movieTime").val();
    const inputtedMovieName = $("#movieName").val();
    const inputtedAgeCheck = $("#ageCheck").val();

    let usrTicket = new Ticket(inputtedMovieName, inputtedMovieTime, inputtedAgeCheck);
  })
  
})