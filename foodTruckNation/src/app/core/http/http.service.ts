import { Injectable } from '@angular/core';
import { HttpClient, HttpHandler } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService extends HttpClient {

  constructor(private httpHandler: HttpHandler) {
    super(httpHandler);
  }
  request(method?: any, url?: any, options?: any): any {
  }
}
