import { TestBed, inject } from '@angular/core/testing';

import { TestUserServiceService } from './test-user-service.service';

describe('TestUserServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [TestUserServiceService]
    });
  });

  it('should be created', inject([TestUserServiceService], (service: TestUserServiceService) => {
    expect(service).toBeTruthy();
  }));
});
