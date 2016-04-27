#lang racket

(define (distance string1 string2)

  (if (not (= (string-length string1) (string-length string2)))
      "Error"
      (char-distance (string->list string1) (string->list string2))))
  
  (define (char-distance chars1 chars2)
    (cond
      ((null? chars1) 0) ; lists empty? we're done.  (Relies on lists of same length)
      (else 
       (let ((countDifferentChar (if (equal? (first chars1) (first chars2)) 0 1)))
         (+ countDifferentChar (char-distance (rest chars1) (rest chars2)))))))
  
(provide distance)