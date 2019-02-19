import { Component, OnInit } from '@angular/core';
import { PaginatedResult } from '../_models/pagination';
import { Movie } from '../_models/movie';
import { TmdbService } from '../_services/tmdb.service';

@Component({
  selector: 'app-premieres',
  templateUrl: './premieres.component.html',
  styleUrls: ['./premieres.component.css']
})
export class PremieresComponent implements OnInit {
  movies: PaginatedResult<Movie[]>;

  constructor(private tmdbService: TmdbService) {}

  ngOnInit() {
    this.getTopMovies();
  }

  getTopMovies() {
    this.tmdbService
      .getTopMovies(
        this.movies ? this.movies.pagination.currentPage : 1,
        8,
        20,
        '',
        'new'
      )
      .subscribe(movies => {
        this.movies = movies;
        this.movies.result.map(movie =>
          localStorage.setItem(movie.id.toString(), JSON.stringify(movie))
        );
        console.log(this.movies);
      });
  }

  pageChanged(event: any): void {
    this.getTopMovies();
  }
}
