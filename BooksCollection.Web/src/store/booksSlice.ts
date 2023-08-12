import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import ApiService from "../services/ApiService";
import { AddBookRequest } from "../models/AddBook";
import { ModifyBookRequest } from "../models/ModifyBook";
import { BookSliceContext } from "../models/BookSliceContext";


export const getBooksList = createAsyncThunk(
  "books/getBooksList",
  async () => {
    return await ApiService.getBooksList();
  }
);

export const addBook = createAsyncThunk(
  "books/addBook",
  async (request: AddBookRequest) => {
    return await ApiService.addBook(request);
  }
);

export const modifyBook = createAsyncThunk(
  "books/modifyBook",
  async (request: ModifyBookRequest) => {
    return await ApiService.modifyBook(request);
  }
);

export const deleteBook = createAsyncThunk(
  "books/deleteBook",
  async (uid: string) => {
    return await ApiService.deleteBook(uid);
  }
);

export const searchGoogleBooks = createAsyncThunk(
  "books/searchGoogleBooks",
  async (title: string) => {
    return await ApiService.searchGoogleBooks(title);
  }
);

const initialState: BookSliceContext = {
  books: [],
  googleSearchBooks: [],
  addModifyBook: {},
};

const booksSlice = createSlice({
  name: "books",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(getBooksList.fulfilled, (state, action) => {
        state.books = action.payload.books;
      })
    .addCase(searchGoogleBooks.fulfilled, (state, action) => {
        state.googleSearchBooks = action.payload.books;
    });
  },
});

export const selectBooks = (state: any) => state.books.books;
export const selectGoogleSearchBooks = (state: any) => state.books.googleSearchBooks;

export default booksSlice.reducer;