import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedResult } from '../_models/pagination';
import { Movie } from '../_models/movie';

@Injectable({
  providedIn: 'root'
})
export class TmdbService {
  baseUrl = environment.tmdbApiUrl;

  constructor(private http: HttpClient) {}

  getTopMovies(
    page?,
    pageSize?,
    resultsLimit?,
    genre?,
    orderBy?
  ): Observable<PaginatedResult<Movie[]>> {
    const paginatedResult: PaginatedResult<Movie[]> = new PaginatedResult<
      Movie[]
    >();

    let params = new HttpParams();

    params = params.append('PageNumber', page ? page : 1);
    params = params.append('PageSize', pageSize ? pageSize : 8);
    params = params.append('ResultsLimit', resultsLimit ? resultsLimit : 1000);
    params = params.append('Genre', genre ? genre : '');
    params = params.append('OrderBy', orderBy ? orderBy : '');

    return this.http
      .get<Movie[]>(this.baseUrl + 'movies', { observe: 'response', params })
      .pipe(
        map(response => {
          paginatedResult.result = response.body;
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(
              response.headers.get('Pagination')
            );
          }
          return paginatedResult;
        })
      );
  }

  getMovieDetails(id: number): Observable<Movie> {
    return this.http.get<Movie>(this.baseUrl + 'movies/' + id);
  }
}
