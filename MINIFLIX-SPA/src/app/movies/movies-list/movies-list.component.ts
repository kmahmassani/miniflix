import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { inject } from '@angular/core/testing';
import { Movie } from 'src/app/_models/movie';
import { PaginatedResult } from 'src/app/_models/pagination';

@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css']
})
export class MoviesListComponent implements OnInit {
  @Input() movies: PaginatedResult<Movie[]>;
  @Output() OnPageChanged = new EventEmitter();

  constructor() {}

  ngOnInit() {}

  pageChanged(event: any): void {
    this.movies.pagination.currentPage = event.page;
    this.OnPageChanged.emit(this.movies.pagination.currentPage);
  }
}
