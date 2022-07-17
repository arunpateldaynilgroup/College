%section A
result(rahim, 3.6).
result(ajay, 3.7).
result(priya, 2.8).
result(rahul, 3.9).
result(kim, 3.10).

%section B
result(sam, 4.0).
result(vickey, 3.9).
result(priyanka, 3.8).
result(ram, 3.6).
result(kunal, 3.0).

getresult :-

write("enter section A student name   : "),nl,
read(X),nl,
result(X,Y),nl,
write("enter section A student result : "),nl,
write(Y),nl,

write("enter section B student name   : "),nl,
read(P),nl,
result(P,Q),nl,
write("enter section B student result : "),nl,
write(Q),nl,

compare(Y,Q).

compare(Y,Q):-

Y>Q, nl,
write("section A student is best ");
Y<Q, nl,
write("section B student is best ");
Y=:=Q, nl,
write("all student are same").
