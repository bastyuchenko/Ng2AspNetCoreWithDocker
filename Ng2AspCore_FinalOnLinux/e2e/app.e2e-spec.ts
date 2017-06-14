import { Ng2AspCorePage } from './app.po';

describe('ng2-asp-core App', () => {
  let page: Ng2AspCorePage;

  beforeEach(() => {
    page = new Ng2AspCorePage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
