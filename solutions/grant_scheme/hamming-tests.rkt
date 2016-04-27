#lang racket

(require rackunit
         "hamming.rkt")

(check-equal? (distance "abc123" "abc123") 
              0
              "identical string")

(check-equal? (distance "abc1234" "xbx1x3x") 
              4
              "string with characters changed")

(check-equal? (distance "a" "ab") 
              "Error"
              "different-length strings don't work")

"**********************"
"*** Tests Complete ***"
"**********************"