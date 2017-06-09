import { Ng2AspCorePage } from './app.po';

describe('ng2-asp-core App', () => {
  let page: Ng2AspCorePage;

  beforeEach(() => {
    page = new Ng2AspCorePage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
