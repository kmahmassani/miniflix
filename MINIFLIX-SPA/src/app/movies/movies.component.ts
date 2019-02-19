import { Component, OnInit } from '@angular/core';
import { Movie } from '../_models/movie';
import { TmdbService } from '../_services/tmdb.service';
import { PaginatedResult } from '../_models/pagination';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  dramaMovies: PaginatedResult<Movie[]>;
  actionMovies: PaginatedResult<Movie[]>;
  comedyMovies: PaginatedResult<Movie[]>;

  constructor(private tmdbService: TmdbService) {}

  ngOnInit() {
    this.getTopMovies();
  }

  getTopMovies() {
    this.tmdbService
      .getTopMovies(1, 3, 3, 'drama', 'rating')
      .subscribe(movies => {
        this.dramaMovies = movies;
        this.dramaMovies.result.map(movie =>
          localStorage.setItem(movie.id.toString(), JSON.stringify(movie))
        );
        console.log(this.dramaMovies);
      });

    this.tmdbService
      .getTopMovies(1, 3, 3, 'action', 'rating')
      .subscribe(movies => {
        this.actionMovies = movies;
        this.actionMovies.result.map(movie =>
          localStorage.setItem(movie.id.toString(), JSON.stringify(movie))
        );
        console.log(this.actionMovies);
      });

    this.tmdbService
      .getTopMovies(1, 3, 3, 'comedy', 'rating')
      .subscribe(movies => {
        this.comedyMovies = movies;
        this.comedyMovies.result.map(movie =>
          localStorage.setItem(movie.id.toString(), JSON.stringify(movie))
        );
        console.log(this.comedyMovies);
      });
  }
}
