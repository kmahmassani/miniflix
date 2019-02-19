import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MoviesComponent } from './movies/movies.component';
import { PremieresComponent } from './premieres/premieres.component';
import { MovieDetailResolver } from './_resolvers/movie-detail.resolver';
import { MovieDetailComponent } from './movies/movie-detail/movie-detail.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'movies', component: MoviesComponent },
  { path: 'premieres', component: PremieresComponent },
  {
    path: 'movies/:id',
    component: MovieDetailComponent,
    resolve: { movie: MovieDetailResolver }
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
