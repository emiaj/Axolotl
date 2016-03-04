import {MediaType} from './mediatype';
import {Position} from './position';
export interface IMedia{
    path: string;
    mediaType: MediaType;
    position:Position;
}