#lang racket

(define (distance string1 string2)
  (if (not (= (string-length string1) (string-length string2)))
      "Error"
      (let ((chars1 (string->list string1)) (chars2 (string->list string2))) ; convert strings to list of chars
        (cond
          ((and (null? chars1) (null? chars2)) 0) ; both lists empty? we're done
          (else 
           (let ((countDifferentChar (if (equal? (first chars1) (first chars2)) 0 1)))
             (+ countDifferentChar (distance (list->string (rest chars1)) (list->string (rest chars2))))))))))
  
(provide distance)