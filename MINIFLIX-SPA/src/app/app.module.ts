import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { PaginationModule } from 'ngx-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { PremieresComponent } from './premieres/premieres.component';
import { MoviesComponent } from './movies/movies.component';
import { HttpClientModule } from '@angular/common/http';
import { MoviesListComponent } from './movies/movies-list/movies-list.component';
import { MovieCardComponent } from './movies/movie-card/movie-card.component';
import { MovieDetailComponent } from './movies/movie-detail/movie-detail.component';
import { MovieDetailResolver } from './_resolvers/movie-detail.resolver';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    PremieresComponent,
    MoviesComponent,
    MoviesListComponent,
    MovieCardComponent,
    MovieDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    PaginationModule.forRoot(),
    FormsModule
  ],
  providers: [MovieDetailResolver],
  bootstrap: [AppComponent]
})
export class AppModule {}
