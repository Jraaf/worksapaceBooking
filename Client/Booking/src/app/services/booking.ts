import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import {
  BookingDto,
  CreateBookingDto,
  WorkspaceDto
} from '../models/booking.model';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  private apiUrl = `${environment.apiUrl}/Booking`;

  constructor(private http: HttpClient) { }

  getAllBookings(): Observable<BookingDto[]> {
    return this.http.get<BookingDto[]>(`${this.apiUrl}/getAll`);
  }

  getBookingById(id: number): Observable<BookingDto> {
    return this.http.get<BookingDto>(`${this.apiUrl}/getById`, {
      params: { id }
    });
  }

  createBooking(booking: CreateBookingDto): Observable<any> {
    return this.http.post(`${this.apiUrl}/add`, booking);
  }

  updateBooking(id: number, booking: CreateBookingDto): Observable<any> {
    return this.http.put(`${this.apiUrl}/${id}/update`, booking);
  }

  deleteBooking(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${id}/delete`);
  }
}
