import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { WorkspaceDto } from '../models/booking.model';

@Injectable({
  providedIn: 'root'
})
export class WorkspaceService {
  private apiUrl = `${environment.apiUrl}/Workspace`;

  constructor(private http: HttpClient) { }

  getAllWorkspaces(): Observable<WorkspaceDto[]> {
    return this.http.get<WorkspaceDto[]>(`${this.apiUrl}/getAll`);
  }

  getWorkspaceById(id: number): Observable<WorkspaceDto> {
    return this.http.get<WorkspaceDto>(`${this.apiUrl}/getById`, {
      params: { id }
    });
  }
}
