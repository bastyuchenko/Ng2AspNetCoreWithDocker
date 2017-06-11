import { IRoleAssignment } from "./role-assignment";

export interface IEmployee {
    employeeId: number;
    firstName: string;
    lastName: string;
    birthDay: Date;
    roleAssignments: Array<IRoleAssignment>;
}