import { initFullHeightGridPage } from '@serenity-is/corelib';
import { MovieGenresGrid } from './MovieGenresGrid';

export default function pageInit() {
    initFullHeightGridPage(new MovieGenresGrid($('#GridDiv')).element);
}