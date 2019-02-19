import {
  HttpInterceptor,
  HttpRequest,
  HttpEvent,
  HttpHandler,
  HTTP_INTERCEPTORS
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable()
export class TMDBTokenInterceptor implements HttpInterceptor {
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    // const token = environment.tmdbApiToken;

    // if (token) {
    //   return next.handle(
    //     req.clone({
    //       headers: req.headers.append('Authorization', 'Bearer ' + token)
    //     })
    //   );
    // }

    return next.handle(req);
  }
}

export const TMDBTokenInterceptorProvider = {
  provide: HTTP_INTERCEPTORS,
  useClass: TMDBTokenInterceptor,
  multi: true
};
