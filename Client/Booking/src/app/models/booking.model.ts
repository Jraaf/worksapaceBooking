export interface CreateBookingDto {
  startDate: Date;
  endDate: Date;
  worksapceId: number;
  bookedEmail: string | null;
}

export interface BookingDto {
  id: number;
  startDate: Date;
  endDate: Date;
  worksapceId: number;
  bookedEmail: string | null;
  workspace: WorkspaceDto;
}

export interface WorkspaceDto {
  id: number;
  capacity: number;
  type: WorkspaceType;
  images: string[];
}

export enum WorkspaceType {
  OpenSpace = 0,
  PrivateRoom = 1,
  MeetingRoom = 2
}
