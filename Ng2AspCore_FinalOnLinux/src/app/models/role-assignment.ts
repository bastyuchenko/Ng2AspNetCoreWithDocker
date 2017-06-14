import { IProject } from "./project";
import { IEmployee } from "./employee";

export interface IRoleAssignment {
    roleAssignmentId: number;
    position: string;
    capacity: number;
    start: Date;
    end: Date;
    groupLeadId: number;
    employeeId: number;
    employee: IEmployee;
    projectId: number;
    project: IProject;
}