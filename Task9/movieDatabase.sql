create table Actors(
	act_id int identity primary key,
	act_fName varchar(50),
	act_lName varchar(50),
	act_gender varchar,
)

create table directors(
	dir_id int identity primary key,
	dir_fNAme varchar(50),
	dir_lNAme varchar(50),
)


create table movies(
	mov_id int identity primary key,
	mov_title varchar(50),
	mov_year int,
	mov_time int,
	mov_lang varchar(50),
	mov_dt_rel date,
	mov_rel_country varchar(5)
)

create table movie_directions(
	dir_id int references directors(dir_id),
	mov_id int references movies(mov_id)
	primary key (dir_id, mov_id)
)

create table movie_casts(
	act_id int references  Actors(act_id),
	mov_id int references movies(mov_id),
	role varchar(30)
	primary key (act_id, mov_id)
)

create table reviewers(
	rev_id int identity primary key,
	rev_name varchar(30)
)

create table genres(
	gen_id int identity primary key,
	gen_title varchar(20)
)

create table movie_genres(
	mov_id  int references movies(mov_id),
	gen_id int references genres(gen_id)

	primary key (mov_id, gen_id)
)

create table ratings(
	mov_id  int references movies(mov_id),
	rev_id int references reviewers(rev_id),
	rev_stars int,
	num_o_ratings int

	primary key (mov_id, rev_id)
)

