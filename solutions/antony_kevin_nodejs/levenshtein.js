#!/usr/local/bin/node

function uniq(s){
   
   var letters = {};
   for(var i=0; i<s.length; i++){
      letters[s[i]] = 1;
   }

   return Object.keys(letters);
}

function levenshtein(start, finish){
   var subs = uniq(finish)

   var myQueue = [];
   var distances = {};

   var addNewString = function(newString, newDistance){
      if(distances[newString] !== undefined){
         return;
      }
      distances[newString] = newDistance;
      myQueue.push(newString);
   }

   myQueue.push(start);
   distances[start] = 0;
   while(true)
   {
      var currentElement = myQueue.shift();
      if(currentElement === finish) return distances[currentElement];

      //don't think this works for adding things to end
      for(var i=0;i!=currentElement.length;++i)
      {
         var lhs = currentElement.substring(0, i) 
         var rhs = currentElement.substring(i+1)
         if(rhs === undefined){
            rhs = "";
         }
        
         //deleted one
         addNewString(lhs+rhs, distances[currentElement]+1)

         for(var j=0;j!=subs.length;++j)
         {
            // substitue
            addNewString(lhs+subs[j]+rhs, distances[currentElement]+1)

            // insert
            addNewString(lhs+currentElement[i]+subs[j]+rhs, distances[currentElement]+1)
         }
      }
   }
}

console.log("Equal strings: (expected 0)                          " + levenshtein("kevin", "kevin"));
console.log("Unequal last character: (expected 1)                 " + levenshtein("kevin", "kevix"));
console.log("Unequal varuous characters: (expected 3)             " + levenshtein("aeaA", "kevAv"));
console.log("Unequal strins with same on the end: (expected 8-10) " + levenshtein("anthonyA", "kevinA"));

