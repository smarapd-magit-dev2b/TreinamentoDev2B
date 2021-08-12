import { combineReducers } from 'redux';
import studentsReducer from '../modules/students/store/students.reducer';

export default combineReducers({ students: studentsReducer });
