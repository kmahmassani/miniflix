import { Component, OnInit } from '@angular/core';
import { TmdbService } from '../_services/tmdb.service';
import { Movie } from '../_models/movie';
import { PaginatedResult } from '../_models/pagination';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  movies: PaginatedResult<Movie[]>;

  constructor(private tmdbService: TmdbService) {}

  ngOnInit() {
    this.getTopMovies();
  }

  getTopMovies() {
    this.tmdbService.getTopMovies(1, 6, 6, '', 'hot').subscribe(movies => {
      this.movies = movies;
    });
  }

  pageChanged(event: any): void {
    this.getTopMovies();
  }
}
