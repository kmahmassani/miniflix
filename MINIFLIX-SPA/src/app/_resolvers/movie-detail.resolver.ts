import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Movie } from '../_models/movie';
import { TmdbService } from '../_services/tmdb.service';

@Injectable()
export class MovieDetailResolver implements Resolve<Movie> {
  constructor(private router: Router, private tmdbService: TmdbService) {}

  resolve(route: ActivatedRouteSnapshot): Observable<Movie> {
    return this.tmdbService.getMovieDetails(route.params.id).pipe(
      catchError(error => {
        console.log('Problem retrieving data');
        this.router.navigate(['/home']);
        return of(null);
      })
    );
  }
}
