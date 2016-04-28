#!/usr/local/bin/node

function hamming(s1, s2){

   if(s1.length != s2.length){
      return "fail";
   }

   var distance = 0;
   for(var i=0; i<s1.length; i++){
      distance += (s1[i] !== s2[i] ? 1 : 0);
   }

   return distance;
}

console.log("Unequal string lengths: (expected fail) " + hamming("antony", "kevin"));
console.log("Equal strings: (expected 0)             " + hamming("kevin", "kevin"));
console.log("Unequal last character: (expected 1)    " + hamming("kevin", "kevix"));
